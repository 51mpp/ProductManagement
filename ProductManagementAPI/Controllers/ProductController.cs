using Microsoft.AspNetCore.Mvc;
using ProductManagementAPI.Interfaces;
using ProductManagementAPI.Models;

namespace ProductManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK , Type = typeof(ICollection<Product>))]

        public IActionResult GetAllProducts()
        {
            var products = _productRepository.GetAllProducts();

            return Ok(products);
        }

        [HttpGet]
        [Route("{code}")]
        [ProducesResponseType(StatusCodes.Status200OK , Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetProductByCode(string code)
        {
            var product = _productRepository.GetProductByCode(code);
            if (product == null)
            {
                return NotFound($"Product with code {code} not found.");
            }
            return Ok(product);
        }
    }

} 
