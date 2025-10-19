using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BarberShopApi.DTOs;
using BarberShopApi.Services;
using BarberShopApi.Models;
using BarberShopApi.Data;
using Microsoft.EntityFrameworkCore;

namespace BarberShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = "AdminOnly")]
    public class AdminController : ControllerBase
    {
        private readonly BarberShopDbContext _context;

        public AdminController(BarberShopDbContext context)
        {
            _context = context;
        }

        [HttpGet("users")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            var users = await _context.Users
                .Where(u => u.IsActive)
                .Select(u => new UserDto
                {
                    Id = u.Id,
                    Username = u.Username,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    PhoneNumber = u.PhoneNumber,
                    DateOfBirth = u.DateOfBirth,
                    Gender = u.Gender,
                    ProfileImageUrl = u.ProfileImageUrl,
                    LoyaltyPoints = u.LoyaltyPoints,
                    CreatedAt = u.CreatedAt,
                    Role = u.Role
                })
                .ToListAsync();

            return Ok(users);
        }

        [HttpPost("create-barber")]
        public async Task<ActionResult<UserDto>> CreateBarber(CreateBarberDto createBarberDto)
        {
            // Check if user already exists
            if (await _context.Users.AnyAsync(u => u.Email == createBarberDto.Email || u.Username == createBarberDto.Username))
            {
                return BadRequest(new { message = "Email hoặc username đã tồn tại" });
            }

            var barber = new User
            {
                Username = createBarberDto.Username,
                Email = createBarberDto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(createBarberDto.Password),
                FirstName = createBarberDto.FirstName,
                LastName = createBarberDto.LastName,
                PhoneNumber = createBarberDto.PhoneNumber,
                DateOfBirth = createBarberDto.DateOfBirth,
                Gender = createBarberDto.Gender,
                Role = Role.Barber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Users.Add(barber);
            await _context.SaveChangesAsync();

            var barberDto = new UserDto
            {
                Id = barber.Id,
                Username = barber.Username,
                Email = barber.Email,
                FirstName = barber.FirstName,
                LastName = barber.LastName,
                PhoneNumber = barber.PhoneNumber,
                DateOfBirth = barber.DateOfBirth,
                Gender = barber.Gender,
                ProfileImageUrl = barber.ProfileImageUrl,
                LoyaltyPoints = barber.LoyaltyPoints,
                CreatedAt = barber.CreatedAt,
                Role = barber.Role
            };

            return Ok(barberDto);
        }

        [HttpPut("users/{id}/role")]
        public async Task<ActionResult> UpdateUserRole(int id, UpdateRoleDto updateRoleDto)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "Không tìm thấy người dùng" });
            }

            user.Role = updateRoleDto.Role;
            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(new { message = "Cập nhật role thành công" });
        }

        [HttpDelete("users/{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { message = "Không tìm thấy người dùng" });
            }

            // Soft delete
            user.IsActive = false;
            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return Ok(new { message = "Xóa người dùng thành công" });
        }

        [HttpGet("dashboard/stats")]
        public async Task<ActionResult<DashboardStatsDto>> GetDashboardStats()
        {
            try
            {
                var today = DateTime.Today;
                var startOfMonth = new DateTime(today.Year, today.Month, 1);
                var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

                // Tổng người dùng
                var totalUsers = await _context.Users
                    .Where(u => u.IsActive)
                    .CountAsync();

                // Tổng sản phẩm
                var totalProducts = await _context.Products.CountAsync();

                // Lịch hẹn hôm nay
                var todayBookings = await _context.Bookings
                    .Where(b => b.BookingDateTime.Date == today)
                    .CountAsync();

                // Doanh thu tháng này
                var monthlyRevenue = await _context.Bookings
                    .Where(b => b.BookingDateTime >= startOfMonth && b.BookingDateTime <= endOfMonth)
                    .Where(b => b.Status == "Completed")
                    .SumAsync(b => b.TotalPrice);

                // Thống kê theo role
                var customersCount = await _context.Users
                    .Where(u => u.IsActive && u.Role == Role.Customer)
                    .CountAsync();

                var barbersCount = await _context.Users
                    .Where(u => u.IsActive && u.Role == Role.Barber)
                    .CountAsync();

                var adminsCount = await _context.Users
                    .Where(u => u.IsActive && u.Role == Role.Admin)
                    .CountAsync();

                // Thống kê booking theo trạng thái
                var pendingBookings = await _context.Bookings
                    .Where(b => b.Status == "Pending")
                    .CountAsync();

                var confirmedBookings = await _context.Bookings
                    .Where(b => b.Status == "Confirmed")
                    .CountAsync();

                var completedBookings = await _context.Bookings
                    .Where(b => b.Status == "Completed")
                    .CountAsync();

                var cancelledBookings = await _context.Bookings
                    .Where(b => b.Status == "Cancelled")
                    .CountAsync();

                var stats = new DashboardStatsDto
                {
                    TotalUsers = totalUsers,
                    TotalProducts = totalProducts,
                    TodayBookings = todayBookings,
                    MonthlyRevenue = monthlyRevenue,
                    CustomersCount = customersCount,
                    BarbersCount = barbersCount,
                    AdminsCount = adminsCount,
                    PendingBookings = pendingBookings,
                    ConfirmedBookings = confirmedBookings,
                    CompletedBookings = completedBookings,
                    CancelledBookings = cancelledBookings
                };

                return Ok(stats);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }
    }

    public class CreateBarberDto
    {
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
    }

    public class UpdateRoleDto
    {
        public Role Role { get; set; }
    }

    public class DashboardStatsDto
    {
        public int TotalUsers { get; set; }
        public int TotalProducts { get; set; }
        public int TodayBookings { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public int CustomersCount { get; set; }
        public int BarbersCount { get; set; }
        public int AdminsCount { get; set; }
        public int PendingBookings { get; set; }
        public int ConfirmedBookings { get; set; }
        public int CompletedBookings { get; set; }
        public int CancelledBookings { get; set; }
    }
}
