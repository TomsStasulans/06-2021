using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("yellow");
            colors.Add("green");
            colors.Add("blue");
            colors.Add("Red");
            colors.Add("black");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
