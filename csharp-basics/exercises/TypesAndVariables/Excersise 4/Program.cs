using System;

namespace Excersise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name and surname");
            string firstAndLastName = Console.ReadLine();
            Console.WriteLine("Please type your year of birth");
            int yearOfBirth = int.Parse(Console.ReadLine());
            Console.WriteLine("My name is {0} and I was born in {1}.", firstAndLastName, yearOfBirth);
            Console.ReadKey();
        }
    }
}
