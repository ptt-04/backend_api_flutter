using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.DTOs
{
    public class HairStyleRequestDto
    {
        [Required]
        public int UserId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FaceShape { get; set; } = string.Empty; // Oval, Round, Square, Heart, Diamond
        
        [Required]
        [StringLength(50)]
        public string HairType { get; set; } = string.Empty; // Straight, Wavy, Curly, Coily
        
        [Required]
        [StringLength(50)]
        public string HairLength { get; set; } = string.Empty; // Short, Medium, Long
        
        public int Age { get; set; }
        
        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string StylePreference { get; set; } = string.Empty; // Casual, Formal, Trendy, Classic
    }

    public class HairStyleSuggestionDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FaceShape { get; set; } = string.Empty;
        public string HairType { get; set; } = string.Empty;
        public string HairLength { get; set; } = string.Empty;
        public string SuggestedStyles { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ChatMessageDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsFromUser { get; set; }
        public string? MessageType { get; set; }
        public string? AttachmentUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class ChatRequestDto
    {
        [Required]
        [StringLength(2000)]
        public string Message { get; set; } = string.Empty;
    }
}

