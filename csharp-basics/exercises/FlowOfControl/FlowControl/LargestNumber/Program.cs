using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            int input2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            int input3 = int.Parse(Console.ReadLine());

            if (input1 > input2 && input1 > input3)
            {
                Console.WriteLine($"Largest number was {input1}");
            } 
            else if (input2 > input1 && input2 > input3)
            {
                Console.WriteLine($"Largest number was {input2}");
            }
            else
            {
                Console.WriteLine($"Largest number was {input3}");
            }

            Console.ReadKey();

            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
             */
        }
    }
}
