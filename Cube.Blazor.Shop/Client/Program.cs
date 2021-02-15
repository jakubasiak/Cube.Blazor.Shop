using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Cube.Blazor.Shop.Client.Services.ProductService;
using Cube.Blazor.Shop.Client.Services.CategoryService;
using Blazored.LocalStorage;
using Blazored.Toast;
using Cube.Blazor.Shop.Client.Services.CartService;

namespace Cube.Blazor.Shop.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICartService, CartService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredToast();

            await builder.Build().RunAsync();
        }
    }
}
