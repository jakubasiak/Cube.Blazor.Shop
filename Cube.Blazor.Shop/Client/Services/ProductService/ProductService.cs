using Cube.Blazor.Shop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public event Action OnChange;
        public List<Product> Products { get; set; } = new List<Product>();

        private readonly HttpClient httpClient;
        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if(string.IsNullOrEmpty(categoryUrl))
            {
                Products = await this.httpClient.GetFromJsonAsync<List<Product>>($"api/Product");
            }
            else
            {           
                Products = await this.httpClient.GetFromJsonAsync<List<Product>>($"api/Product/ByCategory/{categoryUrl}");
            }

            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int id)
        {
            return await this.httpClient.GetFromJsonAsync<Product>($"api/Product/{id}");
        }
    }
}
