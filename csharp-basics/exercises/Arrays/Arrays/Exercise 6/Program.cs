using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray1 = new int[10];
            var random = new Random();

            for (int i = 0; i < numberArray1.Length; i++)
            {
                int randomNumber = random.Next(1, 101);
                numberArray1[i] = randomNumber;
            }

            int[] numberArray2 = new int[10];
            numberArray1.CopyTo(numberArray2, 0);
            numberArray2[9] = -7;

            foreach (int number in numberArray1)
            {
                Console.WriteLine(number);
            }

            foreach (int number in numberArray2)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
