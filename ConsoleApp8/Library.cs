using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Library
    {
        Product[] Products = Array.Empty<Product>();

        public void AddBook(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[^1] = product;
        }

        public Product[] GetProductsByPrice(int minPrice, int maxPrice)
        {
            Product [] product1 = new Product[0];
            foreach (Product product in Products)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                {
                    Array.Resize(ref product1, product1.Length + 1);
                    product1[^1] = product;
                }
            }return product1;
        }

        public Product[] GetProductsByName(string part)
        {
            Product[] product2 = new Product[0];
            foreach(Product product in Products)
            {

                if (product.Name.Contains(part) ==true)
                {
                    Array.Resize(ref product2, product2.Length + 1);
                    product2[^1] = product;
                }
            }return product2;

        }

    }
}
