using BarberShopApi.Data;
using BarberShopApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShopApi.Services
{
    public interface ICartService
    {
        Task<Cart?> GetCartByUserIdAsync(int userId);
        Task<CartItem> AddToCartAsync(int userId, int productId, int quantity);
        Task<CartItem> UpdateCartItemAsync(int cartItemId, int quantity);
        Task<bool> RemoveFromCartAsync(int cartItemId);
        Task<bool> ClearCartAsync(int userId);
        Task<int> GetCartItemCountAsync(int userId);
    }

    public class CartService : ICartService
    {
        private readonly BarberShopDbContext _context;

        public CartService(BarberShopDbContext context)
        {
            _context = context;
        }

        public async Task<Cart?> GetCartByUserIdAsync(int userId)
        {
            return await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId);
        }

        public async Task<CartItem> AddToCartAsync(int userId, int productId, int quantity)
        {
            // Get or create cart
            var cart = await GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                cart = new Cart
                {
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                _context.Carts.Add(cart);
                await _context.SaveChangesAsync();
            }

            // Check if product already exists in cart
            var existingItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.UpdatedAt = DateTime.UtcNow;
                cart.UpdatedAt = DateTime.UtcNow;
                _context.CartItems.Update(existingItem);
                await _context.SaveChangesAsync();
                return existingItem;
            }

            // Get product details
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new ArgumentException("Product not found");
            }

            // Create new cart item
            var cartItem = new CartItem
            {
                CartId = cart.Id,
                ProductId = productId,
                Quantity = quantity,
                ProductPrice = product.Price,
                ProductDiscountPrice = product.DiscountPrice,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.CartItems.Add(cartItem);
            cart.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return cartItem;
        }

        public async Task<CartItem> UpdateCartItemAsync(int cartItemId, int quantity)
        {
            var cartItem = await _context.CartItems
                .Include(ci => ci.Cart)
                .FirstOrDefaultAsync(ci => ci.Id == cartItemId);

            if (cartItem == null)
            {
                throw new ArgumentException("Cart item not found");
            }

            cartItem.Quantity = quantity;
            cartItem.UpdatedAt = DateTime.UtcNow;
            cartItem.Cart.UpdatedAt = DateTime.UtcNow;

            _context.CartItems.Update(cartItem);
            await _context.SaveChangesAsync();

            return cartItem;
        }

        public async Task<bool> RemoveFromCartAsync(int cartItemId)
        {
            var cartItem = await _context.CartItems
                .Include(ci => ci.Cart)
                .FirstOrDefaultAsync(ci => ci.Id == cartItemId);

            if (cartItem == null)
            {
                return false;
            }

            _context.CartItems.Remove(cartItem);
            cartItem.Cart.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ClearCartAsync(int userId)
        {
            var cart = await GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return false;
            }

            _context.CartItems.RemoveRange(cart.CartItems);
            cart.UpdatedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<int> GetCartItemCountAsync(int userId)
        {
            var cart = await GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return 0;
            }

            return cart.CartItems.Sum(ci => ci.Quantity);
        }
    }
}
