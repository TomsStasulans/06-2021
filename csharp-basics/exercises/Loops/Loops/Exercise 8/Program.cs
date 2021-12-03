using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int input = int.Parse(Console.ReadLine());

            int sideLines = input * 3 + (input - 4);
            int stars = 0;

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(new string('/', sideLines) + new string('*', stars) + new string('\\', sideLines));
                stars += 8;
                sideLines -= 4;
            }

            Console.ReadKey();
        }
    }
}
