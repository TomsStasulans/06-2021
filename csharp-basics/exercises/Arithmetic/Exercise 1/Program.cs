using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first integer");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second integer");
            int secondInt = int.Parse(Console.ReadLine());

            if (firstInt == 15 || secondInt == 15)
            {
                Console.WriteLine("true");
            } else if (firstInt - secondInt == 15 || firstInt + secondInt == 15)
            {
                Console.WriteLine("true");
            } else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }
    }
}
