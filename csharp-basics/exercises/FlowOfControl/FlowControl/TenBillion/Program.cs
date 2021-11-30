using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");
            var input = Console.ReadLine();
            long num;
            bool isLong = Int64.TryParse(input, out num);

            if (isLong) 
            {
                if (num < 0) 
                {
                    num *= -1;
                }

                if (num >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int numLength = num.ToString().Length;
                    int digits = 1;
                    if (numLength == 2) 
                    {
                        digits = 2;
                    } 
                    else if (numLength == 3) 
                    {
                        digits = 3;
                    } 
                    else if (numLength == 4) 
                    {
                        digits = 4;
                    } 
                    else if (numLength == 5) 
                    {
                        digits = 5;
                    } 
                    else if (numLength == 6) 
                    {
                        digits = 6;
                    } 
                    else if (numLength == 7) 
                    {
                        digits = 7;
                    } 
                    else if (numLength == 8) 
                    {
                        digits = 8;
                    } 
                    else if (numLength == 9) 
                    {
                        digits = 9;
                    } 
                    else if (numLength == 10) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } 
            else 
            {
                Console.WriteLine("The number is not a long");
            }

            Console.ReadKey();
        }
    }
}
