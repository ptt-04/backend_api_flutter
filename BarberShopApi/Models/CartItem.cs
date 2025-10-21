using System;
using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        
        [Required]
        public int CartId { get; set; }
        
        [Required]
        public int ProductId { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [Required]
        public decimal ProductPrice { get; set; }
        
        public decimal? ProductDiscountPrice { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual Cart Cart { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
