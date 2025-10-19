using Microsoft.AspNetCore.Mvc;
using BarberShopApi.DTOs;
using BarberShopApi.Services;

namespace BarberShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AIController : ControllerBase
    {
        private readonly IAIService _aiService;

        public AIController(IAIService aiService)
        {
            _aiService = aiService;
        }

        [HttpPost("hair-style-suggestion")]
        public async Task<ActionResult<HairStyleSuggestionDto>> GetHairStyleSuggestion(HairStyleRequestDto request)
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                request.UserId = userId;
                var suggestion = await _aiService.GetHairStyleSuggestionAsync(request);
                
                if (suggestion == null)
                {
                    return BadRequest(new { message = "Không thể tạo gợi ý kiểu tóc" });
                }

                return Ok(suggestion);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpPost("chat")]
        public async Task<ActionResult<string>> Chat(ChatRequestDto request)
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var response = await _aiService.GetChatbotResponseAsync(request.Message, userId);
                return Ok(new { response });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }

        [HttpGet("hair-style-history")]
        public async Task<ActionResult<IEnumerable<HairStyleSuggestionDto>>> GetHairStyleHistory()
        {
            try
            {
                var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
                if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
                {
                    return Unauthorized(new { message = "Token không hợp lệ" });
                }

                var history = await _aiService.GetUserHairStyleHistoryAsync(userId);
                return Ok(history);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Lỗi server: " + ex.Message });
            }
        }
    }
}


