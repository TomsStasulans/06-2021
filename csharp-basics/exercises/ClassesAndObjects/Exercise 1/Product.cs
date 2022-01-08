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

        private double _priceAtStart;
        private int _amountAtStart;
        private string _name;

        public string PrintProduct()
        {
            return $"{_name}, {_priceAtStart}, {_amountAtStart}";
        }
    }
}
