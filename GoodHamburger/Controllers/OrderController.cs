using Microsoft.AspNetCore.Mvc;
using GoodHamburguer.Models;

using Microsoft.AspNetCore.Mvc;

namespace GoodHamburguer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet("Summary")]
        public IActionResult GetSummary()
        {
            var summary = new
            {
                orderId = 1234,
                customer = "Gabriel",
                items = new[]
                {
                    new { name = "X-Burger", qty = 1, price = 5.00 },
                    new { name = "Fries", qty = 1, price = 2.00 },
                    new { name = "Soft Drink", qty = 1, price = 2.50 }
                },
                total = 7.60
            };

            return Ok(summary);
        }
    }
}
