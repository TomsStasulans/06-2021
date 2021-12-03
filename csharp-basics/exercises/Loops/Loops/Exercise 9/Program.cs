using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desired sum: ");
            int input = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();

            while (true)
            {
                int numberOne = randomNumber.Next(1, 6);
                int numberTwo = randomNumber.Next(1, 6);
                int sum = numberOne + numberTwo;

                Console.WriteLine($"{numberOne} and {numberTwo} = {sum}");

                if (sum == input)
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
