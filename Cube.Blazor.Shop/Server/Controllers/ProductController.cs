using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cube.Blazor.Shop.Server.Services.ProductService;
using Cube.Blazor.Shop.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cube.Blazor.Shop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            var products = await this.productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet]
        [Route("ByCategory/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var products = await this.productService.GetProductsByCategory(categoryUrl);
            return Ok(products);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await this.productService.GetProduct(id);
            return Ok(product);
        }
    }
}
