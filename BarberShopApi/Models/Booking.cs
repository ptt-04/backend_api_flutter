using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class Booking
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public int ServiceId { get; set; }
        
        [Required]
        public DateTime BookingDateTime { get; set; }
        
        [StringLength(20)]
        public string Status { get; set; } = "Pending"; // Pending, Confirmed, Completed, Cancelled
        
        [StringLength(500)]
        public string? Notes { get; set; }
        
        public decimal TotalPrice { get; set; }
        
        public int? LoyaltyPointsUsed { get; set; }
        
        public int? LoyaltyPointsEarned { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}

