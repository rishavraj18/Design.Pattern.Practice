using Microsoft.AspNetCore.Mvc;
using Singelton.Design.Pattern.Services;

namespace Singelton.Design.Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductCacheService _productCache;

        public ProductsController(IProductCacheService productCache)
        {
            _productCache = productCache;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productCache.GetProducts();
            return Ok(products);
        }
    }
}
