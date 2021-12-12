using System;
using System.Collections.Generic;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myList = new HashSet<string>();
            while(true)
            {
                Console.WriteLine("Please some names: ");
                string input = Console.ReadLine();
                if(input == "")
                {
                    break;
                }
                else
                {
                    myList.Add(input);
                }
            }

            Console.WriteLine(String.Join(" ", myList));
            Console.ReadKey();
        }
    }
}
