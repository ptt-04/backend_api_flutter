using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class HairStyleSuggestion
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string FaceShape { get; set; } = string.Empty; // Oval, Round, Square, Heart, Diamond
        
        [Required]
        [StringLength(100)]
        public string HairType { get; set; } = string.Empty; // Straight, Wavy, Curly, Coily
        
        [Required]
        [StringLength(100)]
        public string HairLength { get; set; } = string.Empty; // Short, Medium, Long
        
        [Required]
        [StringLength(500)]
        public string SuggestedStyles { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string? Description { get; set; }
        
        public string? ImageUrl { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
    }
}








