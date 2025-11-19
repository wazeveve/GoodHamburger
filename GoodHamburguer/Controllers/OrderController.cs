using Microsoft.AspNetCore.Mvc;

namespace GoodHamburguer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet("summary")]
        public IActionResult GetSummary()
        {
            var summary = new
            {
                orderId = 1234,
                customer = "Gabriel",
                items = new[]
                {
                    new { name = "X-Burger", qty = 1, price = 19.90 },
                    new { name = "Fries",    qty = 2, price = 9.00  },
                    new { name = "Soft Drink", qty = 1, price = 6.00 }
                },
                total = 19.90 + 18 + 6
            };

            return Ok(summary);
        }
    }
}
