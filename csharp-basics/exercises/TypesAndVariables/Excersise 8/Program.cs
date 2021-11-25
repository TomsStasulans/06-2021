using System;

namespace Excersise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of minutes");
            int minutes = int.Parse(Console.ReadLine());

            int years = minutes / 525600;
            int days = minutes / 1440;

            Console.WriteLine("{0} minutes are {1} years or {2} days", minutes, years, days);
            Console.ReadKey();
        }
    }
}
