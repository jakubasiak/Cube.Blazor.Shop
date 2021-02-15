using Cube.Blazor.Shop.Server.Data;
using Cube.Blazor.Shop.Server.Services.CategoryService;
using Cube.Blazor.Shop.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService categoryService;
        private readonly DataContext dataContext;

        public ProductService(ICategoryService categoryService, DataContext dataContext)
        {
            this.categoryService = categoryService;
            this.dataContext = dataContext;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await this.dataContext.Products
                .Include(p => p.Variants)
                .ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await this.dataContext.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.Edition)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            var category = await this.categoryService.GetCategoryByUrl(categoryUrl);
            return await this.dataContext.Products
                .Include(p => p.Variants)
                .Where(p => p.CategoryId == category.Id)
                .ToListAsync();
        }
    }
}
