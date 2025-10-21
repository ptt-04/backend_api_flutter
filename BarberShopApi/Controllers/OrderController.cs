using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using BarberShopApi.DTOs;
using BarberShopApi.Services;
using System.Security.Claims;

namespace BarberShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IVNPayService _vnPayService;

        public OrderController(IOrderService orderService, IVNPayService vnPayService)
        {
            _orderService = orderService;
            _vnPayService = vnPayService;
        }

        [HttpPost]
        public async Task<ActionResult<OrderDto>> CreateOrder([FromBody] CreateOrderDto createOrderDto)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                var order = await _orderService.CreateOrderAsync(userId, createOrderDto);
                return Ok(order);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetOrder(int id)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                var order = await _orderService.GetOrderByIdAsync(id);
                
                if (order == null)
                {
                    return NotFound(new { message = "Order not found" });
                }

                // Check if user owns this order or is admin
                if (order.UserId != userId && !User.IsInRole("Admin"))
                {
                    return Forbid();
                }

                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpGet("my-orders")]
        public async Task<ActionResult<List<OrderDto>>> GetMyOrders()
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                var orders = await _orderService.GetUserOrdersAsync(userId);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpGet("all")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<List<OrderDto>>> GetAllOrders()
        {
            try
            {
                var orders = await _orderService.GetAllOrdersAsync();
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpPut("{id}/status")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<OrderDto>> UpdateOrderStatus(int id, [FromBody] UpdateOrderStatusDto updateDto)
        {
            try
            {
                var order = await _orderService.UpdateOrderStatusAsync(id, updateDto.Status);
                return Ok(order);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpGet("branches")]
        public async Task<ActionResult<List<BranchDto>>> GetBranches()
        {
            try
            {
                var branches = await _orderService.GetBranchesAsync();
                return Ok(branches);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpGet("branches/{id}")]
        public async Task<ActionResult<BranchDto>> GetBranch(int id)
        {
            try
            {
                var branch = await _orderService.GetBranchByIdAsync(id);
                if (branch == null)
                {
                    return NotFound(new { message = "Branch not found" });
                }
                return Ok(branch);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpPost("vnpay/create-payment")]
        public async Task<ActionResult<VNPayPaymentResponseDto>> CreateVNPayPayment([FromBody] VNPayPaymentRequestDto request)
        {
            try
            {
                var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "0");
                
                // Verify order belongs to user
                var order = await _orderService.GetOrderByIdAsync(request.OrderId);
                if (order == null || order.UserId != userId)
                {
                    return BadRequest(new { message = "Order not found or access denied" });
                }

                if (order.PaymentMethod != "VNPay")
                {
                    return BadRequest(new { message = "Order is not configured for VNPay payment" });
                }

                var paymentUrl = _vnPayService.CreatePaymentUrl(request);
                var transactionId = Guid.NewGuid().ToString();

                return Ok(new VNPayPaymentResponseDto
                {
                    PaymentUrl = paymentUrl,
                    OrderId = request.OrderId.ToString(),
                    TransactionId = transactionId
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpPost("vnpay/callback")]
        [AllowAnonymous]
        public async Task<ActionResult> VNPayCallback([FromBody] PaymentCallbackDto callback)
        {
            try
            {
                var isValid = _vnPayService.ValidatePaymentCallback(callback);
                if (!isValid)
                {
                    return BadRequest(new { message = "Invalid payment callback" });
                }

                var orderId = int.Parse(callback.vnp_TxnRef);
                var order = await _orderService.GetOrderByIdAsync(orderId);
                
                if (order == null)
                {
                    return BadRequest(new { message = "Order not found" });
                }

                if (callback.vnp_ResponseCode == "00" && callback.vnp_TransactionStatus == "00")
                {
                    // Payment successful
                    await _orderService.UpdateOrderStatusAsync(orderId, "Confirmed");
                    return Ok(new { message = "Payment successful", orderId = orderId });
                }
                else
                {
                    // Payment failed
                    await _orderService.UpdateOrderStatusAsync(orderId, "Cancelled");
                    return Ok(new { message = "Payment failed", orderId = orderId });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }
    }

    public class UpdateOrderStatusDto
    {
        public string Status { get; set; } = string.Empty;
    }
}
