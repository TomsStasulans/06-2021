using System;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] twentyRandomNum = MaketwentyRandomNumbers();

            Console.WriteLine("Which number position out of 20 random numbers you want to know.");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("In position {0} is number {1}", input, twentyRandomNum[input]);
            Console.ReadKey();
        }

        public static int[] MaketwentyRandomNumbers()
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                Random random = new Random();
                int number = random.Next(100);
                numbers[i] = number;
            }

            return numbers;
        }
    }
}
