namespace Exercise_6
{
    public class CozaLozaWoza
    {
        private readonly int _number;

        public CozaLozaWoza(int number)
        {
            _number = number;
        }

        public string ReturnCoza()
        {
            return _number % 3 == 0 ? "Coza" : "";
        }

        public string ReturnLoza()
        {
            return _number % 5 == 0 ? "Loza" : "";
        }

        public string ReturnWoza()
        {
            return _number % 7 == 0 ? "Woza" : "";
        }

        public string ReturnNumber()
        {
            return _number % 3 != 0 && _number % 5 != 0 && _number % 7 != 0 ? $"{_number}" : "";
        }
    }
}