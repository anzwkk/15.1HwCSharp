using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1HW
{
    class Product
    {
        public string Name { get; }
        private decimal BasePrice;

        public Product(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public virtual decimal GetPrice()
        {
            return BasePrice;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {GetPrice()}");
        }
    }
}
