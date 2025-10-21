using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? LoyaltyPointsUsed { get; set; }
        public int? LoyaltyPointsEarned { get; set; }
        public string? PaymentMethod { get; set; }
        public string? DeliveryMethod { get; set; }
        public int? BranchId { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeliveryPhone { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<OrderItemDetailDto> OrderItems { get; set; } = new List<OrderItemDetailDto>();
    }

    public class CreateOrderDto
    {
        [Required]
        public List<CreateOrderItemDto> OrderItems { get; set; } = new List<CreateOrderItemDto>();
        
        public string? PaymentMethod { get; set; }
        public string? DeliveryMethod { get; set; }
        public int? BranchId { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeliveryPhone { get; set; }
        public int? VoucherId { get; set; }
        public int? LoyaltyPointsUsed { get; set; }
        public string? Notes { get; set; }
    }

    public class CreateOrderItemDto
    {
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }

    public class OrderItemDetailDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductImageUrl { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal TotalPrice { get; set; }
    }

    public class BranchDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class VNPayPaymentRequestDto
    {
        [Required]
        public int OrderId { get; set; }
        
        [Required]
        public decimal Amount { get; set; }
        
        public string? ReturnUrl { get; set; }
    }

    public class VNPayPaymentResponseDto
    {
        public string PaymentUrl { get; set; } = string.Empty;
        public string OrderId { get; set; } = string.Empty;
        public string TransactionId { get; set; } = string.Empty;
    }

    public class PaymentCallbackDto
    {
        public string vnp_TxnRef { get; set; } = string.Empty;
        public string vnp_Amount { get; set; } = string.Empty;
        public string vnp_ResponseCode { get; set; } = string.Empty;
        public string vnp_TransactionStatus { get; set; } = string.Empty;
        public string vnp_SecureHash { get; set; } = string.Empty;
    }
}
