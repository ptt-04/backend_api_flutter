using Microsoft.AspNetCore.Mvc;
using BarberShopApi.DTOs;
using BarberShopApi.Services;

namespace BarberShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("my-bookings")]
        public async Task<ActionResult<IEnumerable<BookingDto>>> GetMyBookings()
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var bookings = await _bookingService.GetUserBookingsAsync(userId);
                return Ok(bookings);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPost]
        public async Task<ActionResult<BookingDto>> CreateBooking(CreateBookingDto createBookingDto)
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var booking = await _bookingService.CreateBookingAsync(createBookingDto, userId);
                if (booking == null)
                {
                    return BadRequest(new { message = "Không thể tạo booking. Kiểm tra lại thông tin dịch vụ hoặc điểm thưởng." });
                }

                return CreatedAtAction(nameof(GetMyBookings), new { id = booking.Id }, booking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPut("{id}/status")]
        public async Task<ActionResult<BookingDto>> UpdateBookingStatus(int id, [FromBody] string status)
        {
            try
            {
                var booking = await _bookingService.UpdateBookingStatusAsync(id, status);
                if (booking == null)
                {
                    return NotFound(new { message = "Không tìm thấy booking" });
                }

                return Ok(booking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPut("{id}/cancel")]
        public async Task<ActionResult> CancelBooking(int id)
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var result = await _bookingService.CancelBookingAsync(id, userId);
                if (!result)
                {
                    return NotFound(new { message = "Không tìm thấy booking hoặc không có quyền hủy" });
                }

                return Ok(new { message = "Đã hủy booking thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpGet("services")]
        public async Task<ActionResult<IEnumerable<ServiceDto>>> GetServices()
        {
            try
            {
                var services = await _bookingService.GetServicesAsync();
                return Ok(services);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }
    }
}

