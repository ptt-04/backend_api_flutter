using BarberShopApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BarberShopApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            try
            {
                var userId = GetCurrentUserId();
                var cart = await _cartService.GetCartByUserIdAsync(userId);
                
                if (cart == null)
                {
                    return Ok(new { cartItems = new object[0] });
                }

                var cartItems = cart.CartItems.Select(ci => new
                {
                    id = ci.Id,
                    productId = ci.ProductId,
                    productName = ci.Product.Name,
                    productImageUrl = ci.Product.ImageUrl ?? "",
                    productPrice = ci.ProductPrice,
                    productDiscountPrice = ci.ProductDiscountPrice,
                    quantity = ci.Quantity,
                    totalPrice = ci.Quantity * (ci.ProductDiscountPrice ?? ci.ProductPrice)
                }).ToList();

                return Ok(new { cartItems });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartRequest request)
        {
            try
            {
                var userId = GetCurrentUserId();
                var cartItem = await _cartService.AddToCartAsync(userId, request.ProductId, request.Quantity);
                
                return Ok(new { message = "Product added to cart successfully", cartItem });
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

        [HttpPut("{cartItemId}")]
        public async Task<IActionResult> UpdateCartItem(int cartItemId, [FromBody] UpdateCartItemRequest request)
        {
            try
            {
                var cartItem = await _cartService.UpdateCartItemAsync(cartItemId, request.Quantity);
                return Ok(new { message = "Cart item updated successfully", cartItem });
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

        [HttpDelete("{cartItemId}")]
        public async Task<IActionResult> RemoveFromCart(int cartItemId)
        {
            try
            {
                var result = await _cartService.RemoveFromCartAsync(cartItemId);
                if (!result)
                {
                    return NotFound(new { message = "Cart item not found" });
                }
                return Ok(new { message = "Cart item removed successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpDelete("clear")]
        public async Task<IActionResult> ClearCart()
        {
            try
            {
                var userId = GetCurrentUserId();
                var result = await _cartService.ClearCartAsync(userId);
                if (!result)
                {
                    return NotFound(new { message = "Cart not found" });
                }
                return Ok(new { message = "Cart cleared successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        [HttpGet("count")]
        public async Task<IActionResult> GetCartItemCount()
        {
            try
            {
                var userId = GetCurrentUserId();
                var count = await _cartService.GetCartItemCountAsync(userId);
                return Ok(new { count });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error", error = ex.Message });
            }
        }

        private int GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier);
            if (userIdClaim == null || !int.TryParse(userIdClaim.Value, out int userId))
            {
                throw new UnauthorizedAccessException("Invalid user ID");
            }
            return userId;
        }
    }

    public class AddToCartRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class UpdateCartItemRequest
    {
        public int Quantity { get; set; }
    }
}
