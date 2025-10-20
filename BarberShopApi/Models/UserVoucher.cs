using System.ComponentModel.DataAnnotations;

namespace BarberShopApi.Models
{
    public class UserVoucher
    {
        public int Id { get; set; }
        
        [Required]
        public int UserId { get; set; }
        
        [Required]
        public int VoucherId { get; set; }
        
        public DateTime? UsedAt { get; set; }
        
        public int? OrderId { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        // Navigation properties
        public virtual User User { get; set; } = null!;
        public virtual Voucher Voucher { get; set; } = null!;
        public virtual Order? Order { get; set; }
    }
}





