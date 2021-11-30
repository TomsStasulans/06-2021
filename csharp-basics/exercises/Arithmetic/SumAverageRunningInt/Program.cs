using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            const int lowerBound = 1;
            const int upperBound = 100;
            double avarage = sum / upperBound;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }

            
            Console.WriteLine("The sum of 1 to 100 is {0}", sum);
            Console.WriteLine("The average is {0}", avarage);
            Console.ReadKey();
        }
    }
}

