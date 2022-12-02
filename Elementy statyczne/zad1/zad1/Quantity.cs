using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Quantity
    {
        private static int _quantity = 0;
        public static int quantity { get { return _quantity; } set { _quantity = value; } }

        public Quantity()
        {
            quantity++;
        }

        public static void HowManyObjects()
        {
            Console.WriteLine(quantity);
        }
    }
}
