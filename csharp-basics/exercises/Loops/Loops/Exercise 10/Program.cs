using System;

namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter max number");
            int max = int.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                string result = "";

                for (int j = i; j <= max; j++)
                {
                    result += j;
                }

                for (int k = min; k < min + i - 1; k++)
                {
                    result += k;
                }

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
