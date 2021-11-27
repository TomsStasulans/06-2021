using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double employee1 = TotalPay(7.5, 35);
            double employee2 = TotalPay(8.2, 47);
            double employee3 = TotalPay(10, 73);

            if (employee1 > 0)
            {
                Console.WriteLine(employee1);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            if (employee2 > 0)
            {
                Console.WriteLine(employee2);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            if (employee3 > 0)
            {
                Console.WriteLine(employee3);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.ReadKey();
        }

        public static double TotalPay(double basePay, double hoursWorked)
        {
            if (hoursWorked <= 60 && basePay > 8)
            {
                if (hoursWorked <= 40)
                {
                    return hoursWorked * basePay;
                }
                else
                {
                    return 40 * basePay + (hoursWorked - 40) * (basePay * 1.5);
                }

            }
            else
            {
                return 0;
            }
        }
    }
}