using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.DTOs
{
    public class VoucherDto
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal DiscountAmount { get; set; }
        public string DiscountType { get; set; } = string.Empty;
        public decimal MinimumOrderAmount { get; set; }
        public int MaxUsageCount { get; set; }
        public int UsedCount { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreateVoucherDto
    {
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
        public string DiscountType { get; set; } = string.Empty;
        
        [Required]
        public decimal MinimumOrderAmount { get; set; }
        
        [Required]
        public int MaxUsageCount { get; set; }
        
        [Required]
        public DateTime ValidFrom { get; set; }
        
        [Required]
        public DateTime ValidTo { get; set; }
    }

    public class UserVoucherDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VoucherId { get; set; }
        public DateTime? UsedAt { get; set; }
        public int? OrderId { get; set; }
        public DateTime CreatedAt { get; set; }
        public VoucherDto Voucher { get; set; } = null!;
    }
}


