using System;
using System.Linq;

namespace Excersise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");

            string sentence = Console.ReadLine();
            int upperCaseLetterCount = sentence.Count(letter => char.IsUpper(letter));

            Console.WriteLine("You have {0} upper case letters in your sentence", upperCaseLetterCount);
            Console.ReadLine();
        }
    }
}
