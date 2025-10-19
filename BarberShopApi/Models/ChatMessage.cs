using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class ChatMessage
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        [StringLength(2000)]
        public string Message { get; set; } = string.Empty;
        
        [Required]
        public bool IsFromUser { get; set; } // true if from user, false if from bot
        
        public string? MessageType { get; set; } = "text"; // text, image, file
        
        public string? AttachmentUrl { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
    }
}

