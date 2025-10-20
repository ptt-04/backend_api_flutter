using BarberShopApi.Data;
using BarberShopApi.DTOs;
using BarberShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShopApi.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingDto>> GetUserBookingsAsync(int userId);
        Task<BookingDto?> CreateBookingAsync(CreateBookingDto createBookingDto, int userId);
        Task<BookingDto?> UpdateBookingStatusAsync(int bookingId, string status);
        Task<bool> CancelBookingAsync(int bookingId, int userId);
        Task<IEnumerable<ServiceDto>> GetServicesAsync();
    }

    public class BookingService : IBookingService
    {
        private readonly BarberShopDbContext _context;

        public BookingService(BarberShopDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookingDto>> GetUserBookingsAsync(int userId)
        {
            var bookings = await _context.Bookings
                .Where(b => b.UserId == userId)
                .Include(b => b.Service)
                .OrderByDescending(b => b.BookingDateTime)
                .ToListAsync();

            return bookings.Select(MapToBookingDto);
        }

        public async Task<BookingDto?> CreateBookingAsync(CreateBookingDto createBookingDto, int userId)
        {
            var service = await _context.Services.FindAsync(createBookingDto.ServiceId);
            if (service == null)
            {
                return null;
            }

            // Check if user has enough loyalty points
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return null;
            }

            if (createBookingDto.LoyaltyPointsUsed.HasValue && createBookingDto.LoyaltyPointsUsed > user.LoyaltyPoints)
            {
                return null;
            }

            // Calculate total price
            var totalPrice = service.Price;
            var loyaltyPointsUsed = createBookingDto.LoyaltyPointsUsed ?? 0;
            var loyaltyPointsEarned = (int)(totalPrice / 1000); // 1 point per 1000 VND

            if (loyaltyPointsUsed > 0)
            {
                totalPrice -= loyaltyPointsUsed * 100; // 1 point = 100 VND
            }

            var booking = new Booking
            {
                UserId = userId,
                ServiceId = createBookingDto.ServiceId,
                BookingDateTime = createBookingDto.BookingDateTime,
                Notes = createBookingDto.Notes,
                TotalPrice = totalPrice,
                LoyaltyPointsUsed = loyaltyPointsUsed,
                LoyaltyPointsEarned = loyaltyPointsEarned,
                Status = "Pending",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            _context.Bookings.Add(booking);

            // Update user loyalty points
            user.LoyaltyPoints -= loyaltyPointsUsed;
            user.LoyaltyPoints += loyaltyPointsEarned;
            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            // Reload booking with service
            await _context.Entry(booking).Reference(b => b.Service).LoadAsync();

            return MapToBookingDto(booking);
        }

        public async Task<BookingDto?> UpdateBookingStatusAsync(int bookingId, string status)
        {
            var booking = await _context.Bookings
                .Include(b => b.Service)
                .FirstOrDefaultAsync(b => b.Id == bookingId);

            if (booking == null)
            {
                return null;
            }

            booking.Status = status;
            booking.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();

            return MapToBookingDto(booking);
        }

        public async Task<bool> CancelBookingAsync(int bookingId, int userId)
        {
            var booking = await _context.Bookings
                .FirstOrDefaultAsync(b => b.Id == bookingId && b.UserId == userId);

            if (booking == null)
            {
                return false;
            }

            booking.Status = "Cancelled";
            booking.UpdatedAt = DateTime.UtcNow;

            // Refund loyalty points if used
            if (booking.LoyaltyPointsUsed.HasValue && booking.LoyaltyPointsUsed > 0)
            {
                var user = await _context.Users.FindAsync(userId);
                if (user != null)
                {
                    user.LoyaltyPoints += booking.LoyaltyPointsUsed.Value;
                    user.UpdatedAt = DateTime.UtcNow;
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<ServiceDto>> GetServicesAsync()
        {
            var services = await _context.Services
                .Where(s => s.IsActive)
                .OrderBy(s => s.Name)
                .ToListAsync();

            return services.Select(MapToServiceDto);
        }

        private BookingDto MapToBookingDto(Booking booking)
        {
            return new BookingDto
            {
                Id = booking.Id,
                UserId = booking.UserId,
                ServiceId = booking.ServiceId,
                BookingDateTime = booking.BookingDateTime,
                Status = booking.Status,
                Notes = booking.Notes,
                TotalPrice = booking.TotalPrice,
                LoyaltyPointsUsed = booking.LoyaltyPointsUsed,
                LoyaltyPointsEarned = booking.LoyaltyPointsEarned,
                CreatedAt = booking.CreatedAt,
                Service = MapToServiceDto(booking.Service)
            };
        }

        private ServiceDto MapToServiceDto(Service service)
        {
            return new ServiceDto
            {
                Id = service.Id,
                Name = service.Name,
                Description = service.Description,
                Price = service.Price,
                DurationMinutes = service.DurationMinutes,
                ImageUrl = service.ImageUrl
            };
        }
    }
}





