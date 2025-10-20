using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public decimal Price { get; set; }
        
        public decimal? DiscountPrice { get; set; }
        
        [Required]
        public int StockQuantity { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        
        public string? ImageUrl { get; set; }

    // JSON string storing array of image URLs
    public string? ImageGallery { get; set; }
        
        public string? Brand { get; set; }
        
        [StringLength(50)]
        public string? Size { get; set; }
        
        [StringLength(50)]
        public string? Color { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}

