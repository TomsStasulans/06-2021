using System;

namespace Exercise_5
{
    internal class DateTest
    {
        static void Main(string[] args)
        {
            Date today = new Date(2021, 12, 6);
            Console.WriteLine(today.DisplayDate());
            Console.ReadKey();
        }
    }
}
