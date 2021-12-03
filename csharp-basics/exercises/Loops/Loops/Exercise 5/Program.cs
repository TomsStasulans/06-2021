using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two words");
            Console.WriteLine("Enter first word");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string secondInput = Console.ReadLine();

            int dotsNeeded = 30 - (firstInput.Length + secondInput.Length);
            Console.Write(firstInput);

            for (int i = 0; i < dotsNeeded; i++)
            {
                Console.Write('.');
            }
            
            Console.Write(secondInput);
            Console.ReadKey();
        }
    }
}
