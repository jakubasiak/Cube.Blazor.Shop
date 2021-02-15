using Blazored.LocalStorage;
using Blazored.Toast.Services;
using Cube.Blazor.Shop.Client.Services.ProductService;
using Cube.Blazor.Shop.Shared.Dto;
using Cube.Blazor.Shop.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cube.Blazor.Shop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService localStorageService;
        private readonly IToastService toastService;
        private readonly IProductService productService;

        public event Action OnChange;

        public CartService(
            ILocalStorageService localStorageService,
            IToastService toastService,
            IProductService productService)
        {
            this.localStorageService = localStorageService;
            this.toastService = toastService;
            this.productService = productService;
        }

        public async Task AddToCart(ProductVariant productVariant)
        {
            var cart = await this.localStorageService.GetItemAsync<List<ProductVariant>>("cart");
            if(cart == null)
            {
                cart = new List<ProductVariant>();
            }

            cart.Add(productVariant);
            await this.localStorageService.SetItemAsync("cart", cart);

            var product = await this.productService.GetProduct(productVariant.ProductId);
            this.toastService.ShowSuccess(product.Title, "Added to cart");

            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var result = new List<CartItem>();
            var cart = await this.localStorageService.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart)
            {
                var product = await this.productService.GetProduct(item.ProductId);
                var variant = product.Variants.Find(v => v.EditionId == item.EditionId);
                var cartItem = new CartItem()
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId,
                    EditionName = variant != null ? variant.Edition?.Name : null,
                    Price = variant != null ? variant.Price : 0,
                };

                result.Add(cartItem);
            }

            return result;
        }

        public async Task DeleteItem(CartItem item)
        {
            var cart = await this.localStorageService.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await this.localStorageService.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
