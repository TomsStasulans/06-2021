using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            } else
            {
                Console.WriteLine("Odd Number");
            }
            Console.WriteLine("bye!");
            Console.ReadLine();
        }
    }
}
