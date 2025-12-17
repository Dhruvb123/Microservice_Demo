using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("createOrder")]
        public IActionResult CreateOrder()
        {
            return Ok("Order endpoint hit successfully");
        }

        [HttpGet("paymentMethod")]
        public IActionResult ConfirmPayment(int id)
        {
            return Ok("Calling Payment Method using external Libraries");
        }

        [HttpGet("trackOrder")]
        public IActionResult TrackOrder()
        {
            return Ok("Order Tracking endpoint hit successfully");
        }

    }
}
