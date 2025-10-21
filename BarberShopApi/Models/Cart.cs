using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class Cart
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
