namespace Exercise_2
{
    public class OddOrEven
    {
        private readonly int _number;

        public OddOrEven(int number)
        {
            _number = number;
        }

        public bool CheckIfEven()
        {
            return _number % 2 == 0;
        }

        public bool CheckIfOdd()
        {
            return _number % 2 != 0;
        }
    }
}