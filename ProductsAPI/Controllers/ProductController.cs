using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        [HttpGet("getHomeProducts")]
        public IActionResult GetProducts()
        {
            return Ok("Products endpoint hit successfully");
        }

        [HttpGet("getSpecificProduct")]
        public IActionResult GetProductBySpec(int id)
        {
            return Ok("Specific Products endpoint hit successfully");
        }

        [HttpPost("addProduct")]
        public IActionResult AddProduct(ProductModel product)
        {
            return Ok("Specific Products endpoint hit successfully");
        }


    }
}
