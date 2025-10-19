using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Code { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public decimal DiscountAmount { get; set; }
        
        [Required]
        public string DiscountType { get; set; } = string.Empty; // Percentage, FixedAmount
        
        [Required]
        public decimal MinimumOrderAmount { get; set; }
        
        [Required]
        public int MaxUsageCount { get; set; }
        
        public int UsedCount { get; set; } = 0;
        
        [Required]
        public DateTime ValidFrom { get; set; }
        
        [Required]
        public DateTime ValidTo { get; set; }
        
        public bool IsActive { get; set; } = true;
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual ICollection<UserVoucher> UserVouchers { get; set; } = new List<UserVoucher>();
    }
}


