using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1HW
{
    class Potato : Product
    {
        private int Count;

        public Potato(decimal basePrice, int count) : base("Potato", basePrice)
        {
            Count = count;
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() * Count;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {base.GetPrice()}, Count: {Count}, Total price: {GetPrice()}");
        }
    }
}
