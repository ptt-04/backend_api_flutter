using Microsoft.AspNetCore.SignalR;
using BarberShopApi.Data;
using BarberShopApi.Models;
using BarberShopApi.Services;
using System.Security.Claims;

namespace BarberShopApi.Hubs
{
    public class ChatHub : Hub
    {
        private readonly BarberShopDbContext _context;
        private readonly IAIService _aiService;

        public ChatHub(BarberShopDbContext context, IAIService aiService)
        {
            _context = context;
            _aiService = aiService;
        }

        public override async Task OnConnectedAsync()
        {
            var userId = GetUserId();
            if (userId.HasValue)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, $"user_{userId}");
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var userId = GetUserId();
            if (userId.HasValue)
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"user_{userId}");
            }
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string message)
        {
            var userId = GetUserId();
            if (!userId.HasValue)
            {
                await Clients.Caller.SendAsync("Error", "Người dùng chưa đăng nhập");
                return;
            }

            try
            {
                // Save user message
                var userMessage = new ChatMessage
                {
                    UserId = userId.Value,
                    Message = message,
                    IsFromUser = true,
                    MessageType = "text",
                    CreatedAt = DateTime.UtcNow
                };

                _context.ChatMessages.Add(userMessage);
                await _context.SaveChangesAsync();

                // Send user message to client
                await Clients.Group($"user_{userId}").SendAsync("ReceiveMessage", new
                {
                    Id = userMessage.Id,
                    Message = userMessage.Message,
                    IsFromUser = userMessage.IsFromUser,
                    CreatedAt = userMessage.CreatedAt
                });

                // Get AI response
                var aiResponse = await _aiService.GetChatbotResponseAsync(message, userId.Value);

                // Send AI response to client
                await Clients.Group($"user_{userId}").SendAsync("ReceiveMessage", new
                {
                    Id = 0, // AI response doesn't have ID yet
                    Message = aiResponse,
                    IsFromUser = false,
                    CreatedAt = DateTime.UtcNow
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SendMessage: {ex.Message}");
                await Clients.Caller.SendAsync("Error", "Có lỗi xảy ra khi gửi tin nhắn");
            }
        }

        public async Task JoinSupportGroup()
        {
            var userId = GetUserId();
            if (userId.HasValue)
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, "support");
                await Clients.Group("support").SendAsync("UserJoined", $"User {userId} joined support group");
            }
        }

        public async Task LeaveSupportGroup()
        {
            var userId = GetUserId();
            if (userId.HasValue)
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, "support");
                await Clients.Group("support").SendAsync("UserLeft", $"User {userId} left support group");
            }
        }

        public async Task SendSupportMessage(string message)
        {
            var userId = GetUserId();
            if (!userId.HasValue)
            {
                await Clients.Caller.SendAsync("Error", "Người dùng chưa đăng nhập");
                return;
            }

            try
            {
                var supportMessage = new ChatMessage
                {
                    UserId = userId.Value,
                    Message = message,
                    IsFromUser = true,
                    MessageType = "support",
                    CreatedAt = DateTime.UtcNow
                };

                _context.ChatMessages.Add(supportMessage);
                await _context.SaveChangesAsync();

                await Clients.Group("support").SendAsync("ReceiveSupportMessage", new
                {
                    UserId = userId.Value,
                    Message = message,
                    CreatedAt = supportMessage.CreatedAt
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in SendSupportMessage: {ex.Message}");
                await Clients.Caller.SendAsync("Error", "Có lỗi xảy ra khi gửi tin nhắn hỗ trợ");
            }
        }

        private int? GetUserId()
        {
            var userIdClaim = Context.User?.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
            {
                return userId;
            }
            return null;
        }
    }
}

