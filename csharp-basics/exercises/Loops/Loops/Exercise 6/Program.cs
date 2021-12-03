using System;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter a number");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(i);
                }

                Console.Write(' ');

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
