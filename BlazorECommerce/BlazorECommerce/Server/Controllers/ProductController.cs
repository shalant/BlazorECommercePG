using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorECommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        //formerly held the mock data
        //private static List<Product> Products = new List<Product>
        //{
            
        //};

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
