using System;
using System.Collections.Generic;

namespace ListExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Violet",
                "White",
                "Black"
            };

            Console.WriteLine(string.Join(",", colors));

            colors.RemoveAt(2);
            colors.Insert(2, "Yellow");

            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
