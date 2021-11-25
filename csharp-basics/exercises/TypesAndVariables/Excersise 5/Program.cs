using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] clases = { "Sport", "Latvian", "English", "Mathematics" };
            string[] teachers = { "Berzins", "Kalnins", "Ozolins", "Upite" };
            string dashes = new string('-', 50);

            Console.WriteLine("+" + dashes + "+");

            for (int i = 0; i < clases.Length; i++)
            {
                string clasesSpaces = new string(' ', 28 - clases[i].Length);
                string teachersSpaces = new string(' ', 15 - teachers[i].Length);
                Console.WriteLine("| {0} |{1}{2} " +
                    "|{3}{4} |", i + 1, clasesSpaces, clases[i], teachersSpaces, teachers[i]);
            }

            Console.WriteLine("+" + dashes + "+");
            Console.ReadKey();
        }
    }
}
