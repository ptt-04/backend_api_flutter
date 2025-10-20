using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class Review
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public int ServiceId { get; set; }
        
        [Required]
        public int Rating { get; set; } // 1-5 stars
        
        [StringLength(1000)]
        public string? Comment { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}





