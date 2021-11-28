using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a week day number");
            var input = Console.ReadKey();
            var num = input.KeyChar;
            int dayNumber = num - '0';

            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("\nIt's a Monday!");
                    break;
                case 1:
                    Console.WriteLine("\nIt's a Tuesday!");
                    break;
                case 2:
                    Console.WriteLine("\nIt's a Wednesday!");
                    break;
                case 3:
                    Console.WriteLine("\nIt's a Thursday!");
                    break;
                case 4:
                    Console.WriteLine("\nIt's a Friday!");
                    break;
                case 5:
                    Console.WriteLine("\nIt's a Saturday!");
                    break;
                case 6:
                    Console.WriteLine("\nIt's a Sunday!");
                    break;
                default:
                    Console.WriteLine("\nNot a valid day");
                    break;
            }

            Console.ReadKey();
        }
    }
}
