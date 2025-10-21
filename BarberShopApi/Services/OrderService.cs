using BarberShopApi.Data;
using BarberShopApi.DTOs;
using BarberShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShopApi.Services
{
    public interface IOrderService
    {
        Task<OrderDto> CreateOrderAsync(int userId, CreateOrderDto createOrderDto);
        Task<OrderDto?> GetOrderByIdAsync(int orderId);
        Task<List<OrderDto>> GetUserOrdersAsync(int userId);
        Task<List<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto> UpdateOrderStatusAsync(int orderId, string status);
        Task<List<BranchDto>> GetBranchesAsync();
        Task<BranchDto?> GetBranchByIdAsync(int branchId);
    }

    public class OrderService : IOrderService
    {
        private readonly BarberShopDbContext _context;

        public OrderService(BarberShopDbContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> CreateOrderAsync(int userId, CreateOrderDto createOrderDto)
        {
            // Validate delivery method
            if (createOrderDto.DeliveryMethod == "Pickup" && !createOrderDto.BranchId.HasValue)
            {
                throw new ArgumentException("BranchId is required for pickup delivery");
            }

            if (createOrderDto.DeliveryMethod == "Delivery" && string.IsNullOrEmpty(createOrderDto.DeliveryAddress))
            {
                throw new ArgumentException("DeliveryAddress is required for delivery");
            }

            // Calculate total amount
            decimal totalAmount = 0;
            var orderItems = new List<OrderItem>();

            foreach (var itemDto in createOrderDto.OrderItems)
            {
                var product = await _context.Products.FindAsync(itemDto.ProductId);
                if (product == null)
                {
                    throw new ArgumentException($"Product with ID {itemDto.ProductId} not found");
                }

                if (product.StockQuantity < itemDto.Quantity)
                {
                    throw new ArgumentException($"Insufficient stock for product {product.Name}");
                }

                var unitPrice = product.DiscountPrice ?? product.Price;
                var itemTotal = unitPrice * itemDto.Quantity;
                totalAmount += itemTotal;

                orderItems.Add(new OrderItem
                {
                    ProductId = itemDto.ProductId,
                    Quantity = itemDto.Quantity,
                    UnitPrice = unitPrice,
                    DiscountAmount = product.DiscountPrice.HasValue ? product.Price - product.DiscountPrice.Value : null
                });

                // Update stock
                product.StockQuantity -= itemDto.Quantity;
            }

            // Apply voucher discount
            decimal? discountAmount = null;
            if (createOrderDto.VoucherId.HasValue)
            {
                var voucher = await _context.Vouchers.FindAsync(createOrderDto.VoucherId.Value);
                if (voucher != null && voucher.IsActive && voucher.ValidFrom <= DateTime.UtcNow && voucher.ValidTo >= DateTime.UtcNow)
                {
                    if (totalAmount >= voucher.MinimumOrderAmount)
                    {
                        if (voucher.DiscountType == "Percentage")
                        {
                            discountAmount = totalAmount * (voucher.DiscountAmount / 100);
                        }
                        else if (voucher.DiscountType == "FixedAmount")
                        {
                            discountAmount = voucher.DiscountAmount;
                        }
                    }
                }
            }

            // Apply loyalty points discount
            decimal? loyaltyDiscount = null;
            if (createOrderDto.LoyaltyPointsUsed.HasValue && createOrderDto.LoyaltyPointsUsed > 0)
            {
                var user = await _context.Users.FindAsync(userId);
                if (user != null && user.LoyaltyPoints >= createOrderDto.LoyaltyPointsUsed.Value)
                {
                    loyaltyDiscount = createOrderDto.LoyaltyPointsUsed.Value * 1000; // 1 point = 1000 VND
                    if (loyaltyDiscount > totalAmount)
                    {
                        loyaltyDiscount = totalAmount;
                    }
                }
            }

            // Calculate final amount
            var finalAmount = totalAmount - (discountAmount ?? 0) - (loyaltyDiscount ?? 0);
            if (finalAmount < 0) finalAmount = 0;

            // Calculate loyalty points earned
            var loyaltyPointsEarned = (int)(finalAmount / 1000); // 1000 VND = 1 point

            // Create order
            var order = new Order
            {
                UserId = userId,
                Status = "Pending",
                PaymentMethod = createOrderDto.PaymentMethod,
                DeliveryMethod = createOrderDto.DeliveryMethod,
                TotalAmount = finalAmount,
                DiscountAmount = discountAmount,
                LoyaltyPointsUsed = createOrderDto.LoyaltyPointsUsed,
                LoyaltyPointsEarned = loyaltyPointsEarned,
                BranchId = createOrderDto.BranchId,
                DeliveryAddress = createOrderDto.DeliveryAddress,
                DeliveryPhone = createOrderDto.DeliveryPhone,
                Notes = createOrderDto.Notes,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Add order items
            foreach (var item in orderItems)
            {
                item.OrderId = order.Id;
            }
            _context.OrderItems.AddRange(orderItems);

            // Update user loyalty points
            var userToUpdate = await _context.Users.FindAsync(userId);
            if (userToUpdate != null)
            {
                if (createOrderDto.LoyaltyPointsUsed.HasValue)
                {
                    userToUpdate.LoyaltyPoints -= createOrderDto.LoyaltyPointsUsed.Value;
                }
                userToUpdate.LoyaltyPoints += loyaltyPointsEarned;
            }

            await _context.SaveChangesAsync();

            return await GetOrderByIdAsync(order.Id) ?? throw new Exception("Failed to create order");
        }

        public async Task<OrderDto?> GetOrderByIdAsync(int orderId)
        {
            var order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.Branch)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.Id == orderId);

            if (order == null) return null;

            return new OrderDto
            {
                Id = order.Id,
                UserId = order.UserId,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                DiscountAmount = order.DiscountAmount,
                LoyaltyPointsUsed = order.LoyaltyPointsUsed,
                LoyaltyPointsEarned = order.LoyaltyPointsEarned,
                PaymentMethod = order.PaymentMethod,
                DeliveryMethod = order.DeliveryMethod,
                BranchId = order.BranchId,
                DeliveryAddress = order.DeliveryAddress,
                DeliveryPhone = order.DeliveryPhone,
                Notes = order.Notes,
                CreatedAt = order.CreatedAt,
                UpdatedAt = order.UpdatedAt,
                OrderItems = order.OrderItems.Select(oi => new OrderItemDetailDto
                {
                    Id = oi.Id,
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.Name,
                    ProductImageUrl = oi.Product.ImageUrl ?? "",
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice,
                    DiscountAmount = oi.DiscountAmount,
                    TotalPrice = oi.UnitPrice * oi.Quantity
                }).ToList()
            };
        }

        public async Task<List<OrderDto>> GetUserOrdersAsync(int userId)
        {
            var orders = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.Branch)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.CreatedAt)
                .ToListAsync();

            return orders.Select(order => new OrderDto
            {
                Id = order.Id,
                UserId = order.UserId,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                DiscountAmount = order.DiscountAmount,
                LoyaltyPointsUsed = order.LoyaltyPointsUsed,
                LoyaltyPointsEarned = order.LoyaltyPointsEarned,
                PaymentMethod = order.PaymentMethod,
                DeliveryMethod = order.DeliveryMethod,
                BranchId = order.BranchId,
                DeliveryAddress = order.DeliveryAddress,
                DeliveryPhone = order.DeliveryPhone,
                Notes = order.Notes,
                CreatedAt = order.CreatedAt,
                UpdatedAt = order.UpdatedAt,
                OrderItems = order.OrderItems.Select(oi => new OrderItemDetailDto
                {
                    Id = oi.Id,
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.Name,
                    ProductImageUrl = oi.Product.ImageUrl ?? "",
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice,
                    DiscountAmount = oi.DiscountAmount,
                    TotalPrice = oi.UnitPrice * oi.Quantity
                }).ToList()
            }).ToList();
        }

        public async Task<List<OrderDto>> GetAllOrdersAsync()
        {
            var orders = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.Branch)
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                .OrderByDescending(o => o.CreatedAt)
                .ToListAsync();

            return orders.Select(order => new OrderDto
            {
                Id = order.Id,
                UserId = order.UserId,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                DiscountAmount = order.DiscountAmount,
                LoyaltyPointsUsed = order.LoyaltyPointsUsed,
                LoyaltyPointsEarned = order.LoyaltyPointsEarned,
                PaymentMethod = order.PaymentMethod,
                DeliveryMethod = order.DeliveryMethod,
                BranchId = order.BranchId,
                DeliveryAddress = order.DeliveryAddress,
                DeliveryPhone = order.DeliveryPhone,
                Notes = order.Notes,
                CreatedAt = order.CreatedAt,
                UpdatedAt = order.UpdatedAt,
                OrderItems = order.OrderItems.Select(oi => new OrderItemDetailDto
                {
                    Id = oi.Id,
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.Name,
                    ProductImageUrl = oi.Product.ImageUrl ?? "",
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice,
                    DiscountAmount = oi.DiscountAmount,
                    TotalPrice = oi.UnitPrice * oi.Quantity
                }).ToList()
            }).ToList();
        }

        public async Task<OrderDto> UpdateOrderStatusAsync(int orderId, string status)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null)
            {
                throw new ArgumentException($"Order with ID {orderId} not found");
            }

            order.Status = status;
            order.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return await GetOrderByIdAsync(orderId) ?? throw new Exception("Failed to update order");
        }

        public async Task<List<BranchDto>> GetBranchesAsync()
        {
            var branches = await _context.Branches
                .Where(b => b.IsActive)
                .OrderBy(b => b.Name)
                .ToListAsync();

            return branches.Select(branch => new BranchDto
            {
                Id = branch.Id,
                Name = branch.Name,
                Address = branch.Address,
                Phone = branch.Phone,
                Description = branch.Description,
                IsActive = branch.IsActive,
                CreatedAt = branch.CreatedAt
            }).ToList();
        }

        public async Task<BranchDto?> GetBranchByIdAsync(int branchId)
        {
            var branch = await _context.Branches.FindAsync(branchId);
            if (branch == null) return null;

            return new BranchDto
            {
                Id = branch.Id,
                Name = branch.Name,
                Address = branch.Address,
                Phone = branch.Phone,
                Description = branch.Description,
                IsActive = branch.IsActive,
                CreatedAt = branch.CreatedAt
            };
        }
    }
}
