using System;

namespace Exercise_6
{
    public class ArrayOfTen
    {
        private readonly int[] _numberArray1;
        private readonly int[] _numberArray2;

        public ArrayOfTen()
        {
            _numberArray1 = new int[10];
            _numberArray2 = new int[10];
        }

        public int[] ArrayOfTenRandomNumbers()
        {
            var random = new Random();
            for (int i = 0; i < _numberArray1.Length; i++)
            {
                int randomNumber = random.Next(1, 101);
                _numberArray1[i] = randomNumber;
            }

            return _numberArray1;
        }

        public int[] GetDuplicateArray()
        {
            _numberArray1.CopyTo(_numberArray2, 0);
            return _numberArray2;
        }

        public int[] ArrayWithLastElementChanged()
        {
            _numberArray2[9] = -7;
            return _numberArray2;
        }
    }
}