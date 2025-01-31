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
            bool productsExist = false;

            foreach (var product in products)
            {
                if (product != null)
                {
                    product.PrintInfo();
                    totalPrice += product.GetPrice();
                    productsExist = true;
                }
            }

            if (!productsExist)
            {
                Console.WriteLine("No products in the shop.");
            }
            else
            {
                Console.WriteLine($"Total products price: {totalPrice}");
            }
        }

        public void PrintTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in products)
            {
                if (product != null)
                {
                    totalPrice += product.GetPrice();
                }
            }

            Console.WriteLine($"Total price of all products: {totalPrice}");
        }
    }
}
