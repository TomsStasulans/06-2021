using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            double number = 0;
            while (true)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    number += Math.Pow(double.Parse(input[i].ToString()), 2);
                }

                input = number.ToString();
                if (input.Length == 1 && input == "1")
                {
                    Console.WriteLine("Happy");
                    break;
                }
                else if (input.Length < 2)
                {
                    Console.WriteLine("Not happy");
                    break;
                }

                number = 0;
            }

            Console.ReadKey();
        }
    }
}
