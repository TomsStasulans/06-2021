namespace Exercise_1
{
    public class FifteenMagic
    {
        private readonly int _firstNumber;
        private readonly int _secondNumber;

        public FifteenMagic(int firstNumber, int secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
        public bool IsAnyNumberFifteen()
        {
            return _firstNumber == 15 || _secondNumber == 15;
        }

        public bool IsSumOrDifferenceFifteen()
        {
            return _firstNumber - _secondNumber == 15 || _firstNumber + _secondNumber == 15;
        }
    }
}