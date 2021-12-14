using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = @"C:\Projects\06-2021\csharp-basics\exercises\Collections\Histogram\midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path);
            var readTextLines = string.Join(" ", readText);
            var stringMarks = readTextLines.Split(' ');
            int[] marks = Array.ConvertAll(stringMarks, int.Parse);
            var result = new Dictionary<string, string>
            {
                {"00-09", "" },
                {"10-19", "" },
                {"20-29", "" },
                {"30-39", "" },
                {"40-49", "" },
                {"50-59", "" },
                {"60-69", "" },
                {"70-79", "" },
                {"80-89", "" },
                {"90-99", "" },
                {"  100", "" },
            };

            for (int i = 0; i < 100; i += 10)
            {
                result[$"{i:00}-{i + 9:00}"] += new string('*', marks.Count(num => num > i && num < i + 9));
            }

            result["  100"] += new string('*', marks.Count(num => num ==100));

            foreach (var line in result)
            {
                Console.WriteLine(line.Key + ": " + line.Value);
            }

            Console.ReadKey();
        }
    }
}
