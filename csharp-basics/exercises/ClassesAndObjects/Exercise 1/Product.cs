using System;

namespace Exercise_1
{
    internal class Product
    {
        public Product(double priceAtStart, int amountAtStart, string name)
        {
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
            _name = name;
        }

        private double _priceAtStart;
        private int _amountAtStart;
        private string _name;

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, {_priceAtStart}, {_amountAtStart} ");
        }
    }
}
