using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cube.Blazor.Shop.Server.Services.CategoryService;
using Cube.Blazor.Shop.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cube.Blazor.Shop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            var categories = await this.categoryService.GetCategories();
            return Ok(categories);
        }
    }
}
