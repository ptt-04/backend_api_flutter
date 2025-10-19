using BarberShopApi.Data;
using BarberShopApi.DTOs;
using BarberShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BarberShopApi.Services
{
    public interface IAIService
    {
        Task<HairStyleSuggestionDto?> GetHairStyleSuggestionAsync(HairStyleRequestDto request);
        Task<string> GetChatbotResponseAsync(string message, int userId);
        Task<IEnumerable<HairStyleSuggestionDto>> GetUserHairStyleHistoryAsync(int userId);
    }

    public class AIService : IAIService
    {
        private readonly BarberShopDbContext _context;
        private readonly IConfiguration _configuration;

        public AIService(BarberShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<HairStyleSuggestionDto?> GetHairStyleSuggestionAsync(HairStyleRequestDto request)
        {
            try
            {
                // Mock AI response for now
                var response = GenerateMockHairStyleResponse(request);

                var suggestion = new HairStyleSuggestion
                {
                    UserId = request.UserId,
                    FaceShape = request.FaceShape,
                    HairType = request.HairType,
                    HairLength = request.HairLength,
                    SuggestedStyles = response,
                    Description = $"Gợi ý kiểu tóc cho khuôn mặt {request.FaceShape}, tóc {request.HairType} {request.HairLength}",
                    CreatedAt = DateTime.UtcNow
                };

                _context.HairStyleSuggestions.Add(suggestion);
                await _context.SaveChangesAsync();

                return MapToHairStyleSuggestionDto(suggestion);
            }
            catch (Exception ex)
            {
                // Log error
                Console.WriteLine($"Error in GenerateHairStyleSuggestion: {ex.Message}");
                return null;
            }
        }

        public async Task<string> GetChatbotResponseAsync(string message, int userId)
        {
            try
            {
                // Mock chatbot response for now
                var response = GenerateMockChatbotResponse(message);

                // Save chat message
                var chatMessage = new ChatMessage
                {
                    UserId = userId,
                    Message = message,
                    IsFromUser = true,
                    CreatedAt = DateTime.UtcNow
                };

                var botResponse = new ChatMessage
                {
                    UserId = userId,
                    Message = response,
                    IsFromUser = false,
                    CreatedAt = DateTime.UtcNow
                };

                _context.ChatMessages.AddRange(chatMessage, botResponse);
                await _context.SaveChangesAsync();

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetChatbotResponse: {ex.Message}");
                return "Xin lỗi, tôi không thể trả lời câu hỏi này ngay bây giờ. Vui lòng thử lại sau.";
            }
        }

        public async Task<IEnumerable<HairStyleSuggestionDto>> GetUserHairStyleHistoryAsync(int userId)
        {
            var suggestions = await _context.HairStyleSuggestions
                .Where(h => h.UserId == userId)
                .OrderByDescending(h => h.CreatedAt)
                .ToListAsync();

            return suggestions.Select(MapToHairStyleSuggestionDto);
        }

        private string GenerateMockHairStyleResponse(HairStyleRequestDto request)
        {
            return $@"
Dựa trên thông tin bạn cung cấp, tôi có một số gợi ý kiểu tóc phù hợp:

**1. Kiểu tóc phù hợp với khuôn mặt {request.FaceShape}:**
- Khuôn mặt {request.FaceShape} thường phù hợp với nhiều kiểu tóc khác nhau
- Tóc {request.HairLength.ToLower()} sẽ tạo sự cân bằng tốt

**2. Gợi ý cụ thể:**
- **Kiểu Modern Crop**: Phù hợp với tóc {request.HairType.ToLower()}, tạo vẻ năng động
- **Kiểu Textured Quiff**: Phù hợp với phong cách {request.StylePreference.ToLower()}
- **Kiểu Side Part**: Phù hợp với phong cách {request.StylePreference.ToLower()}

**3. Lưu ý chăm sóc:**
- Sử dụng sản phẩm phù hợp với tóc {request.HairType.ToLower()}
- Cắt tỉa định kỳ 4-6 tuần
- Sử dụng dầu gội và dầu xả chất lượng

**4. Sản phẩm khuyến nghị:**
- Gel tạo kiểu cho tóc {request.HairType.ToLower()}
- Pomade cho phong cách {request.StylePreference.ToLower()}
- Wax cho kiểu tóc tự nhiên

Bạn có muốn đặt lịch cắt tóc với kiểu được gợi ý không?
";
        }

        private string GenerateMockChatbotResponse(string message)
        {
            var messageLower = message.ToLower();
            
            if (messageLower.Contains("giá") || messageLower.Contains("phí"))
            {
                return "Chúng tôi có các dịch vụ cắt tóc nam từ 150.000đ, cắt tóc nữ từ 200.000đ. Bạn có muốn xem chi tiết không?";
            }
            else if (messageLower.Contains("đặt lịch") || messageLower.Contains("booking"))
            {
                return "Bạn có thể đặt lịch qua ứng dụng hoặc gọi điện trực tiếp. Thời gian làm việc: 8:00 - 20:00 hàng ngày.";
            }
            else if (messageLower.Contains("kiểu tóc") || messageLower.Contains("style"))
            {
                return "Chúng tôi có nhiều kiểu tóc phù hợp với từng khuôn mặt. Bạn có thể sử dụng tính năng AI tư vấn để được gợi ý kiểu tóc phù hợp.";
            }
            else if (messageLower.Contains("sản phẩm") || messageLower.Contains("mua"))
            {
                return "Chúng tôi có nhiều sản phẩm chăm sóc tóc chất lượng cao. Bạn có thể xem trong phần Cửa hàng của ứng dụng.";
            }
            else
            {
                return "Cảm ơn bạn đã liên hệ! Tôi có thể giúp bạn về dịch vụ cắt tóc, đặt lịch, sản phẩm chăm sóc tóc. Bạn cần hỗ trợ gì thêm không?";
            }
        }

        private HairStyleSuggestionDto MapToHairStyleSuggestionDto(HairStyleSuggestion suggestion)
        {
            return new HairStyleSuggestionDto
            {
                Id = suggestion.Id,
                UserId = suggestion.UserId,
                FaceShape = suggestion.FaceShape,
                HairType = suggestion.HairType,
                HairLength = suggestion.HairLength,
                SuggestedStyles = suggestion.SuggestedStyles,
                Description = suggestion.Description,
                ImageUrl = suggestion.ImageUrl,
                CreatedAt = suggestion.CreatedAt
            };
        }
    }
}
