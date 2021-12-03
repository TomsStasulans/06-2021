using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {       
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[maxNumber - minNumber + 1];
            int number = minNumber;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = number + i;
            }

            sum = arrayOfNumbers.Sum();
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
