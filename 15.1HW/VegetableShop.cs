using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1HW
{
    internal class VegetableShop
    {
        private Product[] products;
        private int currentIndex = 0;

        public VegetableShop(int maxProducts)
        {
            products = new Product[maxProducts];
        }

        public void AddProduct(Product product)
        {
            if (currentIndex < products.Length)
            {
                products[currentIndex] = product;
                currentIndex++;
            }
            else
            {
                Console.WriteLine("Shop is full! Cannot add more products");
            }
        }
        public void PrintProductsInfo()
        {
            decimal totalPrice = 0;

            foreach (var product in products)
            {
                product.PrintInfo();
                totalPrice += product.GetPrice();
            }

            Console.WriteLine($"Total products price: {totalPrice}");
        }
    }
}
