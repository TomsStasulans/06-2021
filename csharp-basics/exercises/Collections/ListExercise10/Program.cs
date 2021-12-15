using System;
using System.Collections.Generic;

namespace ListExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            Console.WriteLine("Original array list: ");
            Console.WriteLine(string.Join(",", colors));

            colors.RemoveAll(c => c == c);

            Console.WriteLine("New array list: ");
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
