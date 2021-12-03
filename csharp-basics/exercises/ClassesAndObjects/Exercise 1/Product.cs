using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class Product
    {
        public Product(double priceAtStart, int amountAtStart, string name)
        {
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
            _name = name;
        }

        private double _priceAtStart { get; set; }
        private int _amountAtStart { get; set; }
        private string _name { get; }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, {_priceAtStart}, {_amountAtStart} ");
        }
    }
}
