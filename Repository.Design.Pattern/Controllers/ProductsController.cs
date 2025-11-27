using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Design.Pattern.Models;
using Repository.Design.Pattern.Repositories;

namespace Repository.Design.Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductsController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productRepo.GetAllAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Products product)
        {
            await _productRepo.AddAsync(product);
            await _productRepo.SaveAsync();
            return CreatedAtAction(nameof(GetAll), product);
        }
    }
}
