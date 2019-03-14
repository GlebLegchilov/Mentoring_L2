using AsyncAwait.Task3.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Task3
{
    public class ProductShop
    {
        public IList<Product> ShopList { get; }
        public IList<Product> BasketList { get; private set; }
        public double CurentTotalPrice { get; private set; }

        public ProductShop()
        {
            ShopList = new List<Product>()
            {
                new Product("Potato", 28),
                new Product("Buter", 79),
                new Product("Oliv oil", 64)
            };
            BasketList = new List<Product>();
            CurentTotalPrice = 0;
        }

        public void AddProductToBasket(Product product)
        {
            BasketList.Add(product);
            CurentTotalPrice = CurentTotalPrice + product.Price;
            Thread.Sleep(5000);
        }
        
        public void ExcludeProductFromBasket(Product product)
        {
            BasketList.Remove(product);
            CurentTotalPrice = CurentTotalPrice - product.Price;
            Thread.Sleep(5000);
        }

        public async Task AddProductToBasketAsync(Product product)
        {
            await Task.Run(() => AddProductToBasket(product));
        }
        
        public async Task ExcludeProductFromBasketAsync(Product product)
        {
            await Task.Run(() => ExcludeProductFromBasket(product));
        }
    }
}

