using Microsoft.AspNetCore.Mvc;
using BarberShopApi.DTOs;
using BarberShopApi.Services;

namespace BarberShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }

        [HttpGet("available")]
        public async Task<ActionResult<IEnumerable<VoucherDto>>> GetAvailableVouchers()
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var vouchers = await _voucherService.GetAvailableVouchersAsync(userId);
                return Ok(vouchers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpGet("my-vouchers")]
        public async Task<ActionResult<IEnumerable<UserVoucherDto>>> GetMyVouchers()
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var vouchers = await _voucherService.GetUserVouchersAsync(userId);
                return Ok(vouchers);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPost]
        public async Task<ActionResult<VoucherDto>> CreateVoucher(CreateVoucherDto createVoucherDto)
        {
            try
            {
                var voucher = await _voucherService.CreateVoucherAsync(createVoucherDto);
                if (voucher == null)
                {
                    return BadRequest(new { message = "Không thể tạo voucher" });
                }

                return CreatedAtAction(nameof(GetAvailableVouchers), new { id = voucher.Id }, voucher);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPost("{voucherId}/assign")]
        public async Task<ActionResult> AssignVoucher(int voucherId)
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var result = await _voucherService.AssignVoucherToUserAsync(userId, voucherId);
                if (!result)
                {
                    return BadRequest(new { message = "Không thể nhận voucher này" });
                }

                return Ok(new { message = "Đã nhận voucher thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPost("{voucherId}/use")]
        public async Task<ActionResult> UseVoucher(int voucherId, [FromBody] int? orderId = null)
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var result = await _voucherService.UseVoucherAsync(userId, voucherId, orderId);
                if (!result)
                {
                    return BadRequest(new { message = "Không thể sử dụng voucher này" });
                }

                return Ok(new { message = "Đã sử dụng voucher thành công" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }
    }
}


