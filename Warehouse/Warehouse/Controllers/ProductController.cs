using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Models;
using Warehouse.Services;

namespace Warehouse.Controllers
{
    /// <summary>
    /// Controls HTTP requests for products
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IProduct>>> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        // GET api/product/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<IProduct>> GetProductById(int id)
        {
            var product = await _productService.GetProductByIdAsync(id);
            return Ok(product);
        }

        // POST api/products
        [HttpPost]
        public async Task<ActionResult<IProduct>> CreateProduct([FromBody] IProduct product)
        {
            var createdProduct = await _productService.CreateProductAsync(product.Name,product.Price);
            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
        }

        // PUT api/products/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var updatedProduct = await _productService.UpdateProductAsync(product);

            if (updatedProduct == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
