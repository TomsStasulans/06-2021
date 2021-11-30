using System;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
