using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Shipped, Delivered, Cancelled
        
        public decimal TotalAmount { get; set; }
        
        public decimal? DiscountAmount { get; set; }
        
        public int? LoyaltyPointsUsed { get; set; }
        
        public int? LoyaltyPointsEarned { get; set; }
        
        [StringLength(200)]
        public string? ShippingAddress { get; set; }
        
        [StringLength(15)]
        public string? ShippingPhone { get; set; }
        
        [StringLength(500)]
        public string? Notes { get; set; }
        
        // Thêm các thuộc tính thiếu
        [StringLength(50)]
        public string? PaymentMethod { get; set; }
        
        [StringLength(50)]
        public string? DeliveryMethod { get; set; }
        
        public int? BranchId { get; set; }
        
        [StringLength(200)]
        public string? DeliveryAddress { get; set; }
        
        [StringLength(15)]
        public string? DeliveryPhone { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public virtual Branch? Branch { get; set; }
    }
}

