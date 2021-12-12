using System;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFromFile = @"C:\Projects\06-2021\csharp-basics\exercises\Collections\WordCount\lear.txt";
            string text = System.IO.File.ReadAllText(textFromFile);
            var lineCount = File.ReadLines(textFromFile).Count();
            int wordCount = text.Split(' ').ToList().Count;
            int charCount = text.ToCharArray().Count();

            Console.WriteLine("lines = " + lineCount);
            Console.WriteLine("words = " + wordCount);
            Console.WriteLine("Chars = " + charCount);
            Console.ReadKey();
        }
    }
}
