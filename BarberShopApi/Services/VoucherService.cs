using BarberShopApi.Data;
using BarberShopApi.DTOs;
using BarberShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShopApi.Services
{
    public interface IVoucherService
    {
        Task<IEnumerable<VoucherDto>> GetAvailableVouchersAsync(int userId);
        Task<IEnumerable<UserVoucherDto>> GetUserVouchersAsync(int userId);
        Task<VoucherDto?> CreateVoucherAsync(CreateVoucherDto createVoucherDto);
        Task<bool> UseVoucherAsync(int userId, int voucherId, int? orderId = null);
        Task<bool> AssignVoucherToUserAsync(int userId, int voucherId);
        
        // Admin methods
        Task<IEnumerable<VoucherDto>> GetAllVouchersAsync();
        Task<VoucherDto?> GetVoucherByIdAsync(int id);
        Task<VoucherDto?> UpdateVoucherAsync(int id, CreateVoucherDto updateVoucherDto);
        Task<bool> DeleteVoucherAsync(int id);
        Task<IEnumerable<UserVoucherDto>> GetAllUserVouchersAsync();
    }

    public class VoucherService : IVoucherService
    {
        private readonly BarberShopDbContext _context;

        public VoucherService(BarberShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VoucherDto>> GetAvailableVouchersAsync(int userId)
        {
            var now = DateTime.UtcNow;
            var vouchers = await _context.Vouchers
                .Where(v => v.IsActive && 
                           v.ValidFrom <= now && 
                           v.ValidTo >= now &&
                           v.UsedCount < v.MaxUsageCount)
                .OrderBy(v => v.ValidTo)
                .ToListAsync();

            return vouchers.Select(MapToVoucherDto);
        }

        public async Task<IEnumerable<UserVoucherDto>> GetUserVouchersAsync(int userId)
        {
            var userVouchers = await _context.UserVouchers
                .Include(uv => uv.Voucher)
                .Where(uv => uv.UserId == userId)
                .OrderByDescending(uv => uv.CreatedAt)
                .ToListAsync();

            return userVouchers.Select(MapToUserVoucherDto);
        }

        public async Task<VoucherDto?> CreateVoucherAsync(CreateVoucherDto createVoucherDto)
        {
            var voucher = new Voucher
            {
                Code = createVoucherDto.Code,
                Name = createVoucherDto.Name,
                Description = createVoucherDto.Description,
                DiscountAmount = createVoucherDto.DiscountAmount,
                DiscountType = createVoucherDto.DiscountType,
                MinimumOrderAmount = createVoucherDto.MinimumOrderAmount,
                MaxUsageCount = createVoucherDto.MaxUsageCount,
                ValidFrom = createVoucherDto.ValidFrom,
                ValidTo = createVoucherDto.ValidTo,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Vouchers.Add(voucher);
            await _context.SaveChangesAsync();

            return MapToVoucherDto(voucher);
        }

        public async Task<bool> UseVoucherAsync(int userId, int voucherId, int? orderId = null)
        {
            var userVoucher = await _context.UserVouchers
                .Include(uv => uv.Voucher)
                .FirstOrDefaultAsync(uv => uv.UserId == userId && uv.VoucherId == voucherId);

            if (userVoucher == null || userVoucher.UsedAt.HasValue)
            {
                return false;
            }

            var now = DateTime.UtcNow;
            if (userVoucher.Voucher.ValidTo < now || userVoucher.Voucher.ValidFrom > now)
            {
                return false;
            }

            userVoucher.UsedAt = now;
            userVoucher.OrderId = orderId;

            // Update voucher usage count
            userVoucher.Voucher.UsedCount++;
            userVoucher.Voucher.UpdatedAt = now;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AssignVoucherToUserAsync(int userId, int voucherId)
        {
            var voucher = await _context.Vouchers.FindAsync(voucherId);
            if (voucher == null || !voucher.IsActive)
            {
                return false;
            }

            var now = DateTime.UtcNow;
            if (voucher.ValidTo < now || voucher.ValidFrom > now)
            {
                return false;
            }

            // Check if user already has this voucher
            var existingUserVoucher = await _context.UserVouchers
                .FirstOrDefaultAsync(uv => uv.UserId == userId && uv.VoucherId == voucherId);

            if (existingUserVoucher != null)
            {
                return false;
            }

            var userVoucher = new UserVoucher
            {
                UserId = userId,
                VoucherId = voucherId,
                CreatedAt = now
            };

            _context.UserVouchers.Add(userVoucher);
            await _context.SaveChangesAsync();

            return true;
        }

        private VoucherDto MapToVoucherDto(Voucher voucher)
        {
            return new VoucherDto
            {
                Id = voucher.Id,
                Code = voucher.Code,
                Name = voucher.Name,
                Description = voucher.Description,
                DiscountAmount = voucher.DiscountAmount,
                DiscountType = voucher.DiscountType,
                MinimumOrderAmount = voucher.MinimumOrderAmount,
                MaxUsageCount = voucher.MaxUsageCount,
                UsedCount = voucher.UsedCount,
                ValidFrom = voucher.ValidFrom,
                ValidTo = voucher.ValidTo,
                CreatedAt = voucher.CreatedAt
            };
        }

        private UserVoucherDto MapToUserVoucherDto(UserVoucher userVoucher)
        {
            return new UserVoucherDto
            {
                Id = userVoucher.Id,
                UserId = userVoucher.UserId,
                VoucherId = userVoucher.VoucherId,
                UsedAt = userVoucher.UsedAt,
                OrderId = userVoucher.OrderId,
                CreatedAt = userVoucher.CreatedAt,
                Voucher = MapToVoucherDto(userVoucher.Voucher)
            };
        }

        // Admin methods implementation
        public async Task<IEnumerable<VoucherDto>> GetAllVouchersAsync()
        {
            var vouchers = await _context.Vouchers
                .OrderByDescending(v => v.CreatedAt)
                .ToListAsync();

            Console.WriteLine($"Found {vouchers.Count} vouchers in database");
            foreach (var voucher in vouchers)
            {
                Console.WriteLine($"Voucher: {voucher.Name} (IsActive: {voucher.IsActive})");
            }

            return vouchers.Select(MapToVoucherDto);
        }

        public async Task<VoucherDto?> GetVoucherByIdAsync(int id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            return voucher != null ? MapToVoucherDto(voucher) : null;
        }

        public async Task<VoucherDto?> UpdateVoucherAsync(int id, CreateVoucherDto updateVoucherDto)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher == null) return null;

            voucher.Code = updateVoucherDto.Code;
            voucher.Name = updateVoucherDto.Name;
            voucher.Description = updateVoucherDto.Description;
            voucher.DiscountAmount = updateVoucherDto.DiscountAmount;
            voucher.DiscountType = updateVoucherDto.DiscountType;
            voucher.MinimumOrderAmount = updateVoucherDto.MinimumOrderAmount;
            voucher.MaxUsageCount = updateVoucherDto.MaxUsageCount;
            voucher.ValidFrom = updateVoucherDto.ValidFrom;
            voucher.ValidTo = updateVoucherDto.ValidTo;
            voucher.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return MapToVoucherDto(voucher);
        }

        public async Task<bool> DeleteVoucherAsync(int id)
        {
            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher == null) return false;

            _context.Vouchers.Remove(voucher);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<UserVoucherDto>> GetAllUserVouchersAsync()
        {
            var userVouchers = await _context.UserVouchers
                .Include(uv => uv.Voucher)
                .OrderByDescending(uv => uv.CreatedAt)
                .ToListAsync();

            Console.WriteLine($"Found {userVouchers.Count} user vouchers in database");
            foreach (var userVoucher in userVouchers)
            {
                Console.WriteLine($"UserVoucher: User {userVoucher.UserId} has voucher {userVoucher.Voucher.Name} (Used: {userVoucher.UsedAt != null})");
            }

            return userVouchers.Select(MapToUserVoucherDto);
        }
    }
}





