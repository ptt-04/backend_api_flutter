using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.DTOs
{
    public class BookingDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public DateTime BookingDateTime { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? Notes { get; set; }
        public decimal TotalPrice { get; set; }
        public int? LoyaltyPointsUsed { get; set; }
        public int? LoyaltyPointsEarned { get; set; }
        public DateTime CreatedAt { get; set; }
        public ServiceDto Service { get; set; } = null!;
    }

    public class CreateBookingDto
    {
        [Required]
        public int ServiceId { get; set; }
        
        [Required]
        public DateTime BookingDateTime { get; set; }
        
        public string? Notes { get; set; }
        
        public int? LoyaltyPointsUsed { get; set; }
    }

    public class ServiceDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int DurationMinutes { get; set; }
        public string? ImageUrl { get; set; }
    }
}

