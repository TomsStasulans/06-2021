using System;

namespace Excersise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first single digit number");
            int firstDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second single digit number");
            int secondDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third single digit number");
            int thirdDigit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter fourth single digit number");
            int fourthDigit = int.Parse(Console.ReadLine());

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            Console.WriteLine("Sum of all the digits you entered is {0}", sum);
            Console.ReadLine();
        }
    }
}
