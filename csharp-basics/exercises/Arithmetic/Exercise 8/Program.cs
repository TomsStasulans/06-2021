using System;

namespace Exercise_8
{
    public class CalculateSalary
    {
        private readonly double _basePay;
        private readonly double _hoursWorked;

        public CalculateSalary(double basePay, double hoursWorked)
        {
            _basePay = basePay;
            _hoursWorked = hoursWorked;
        }

        public double CalculateTotalPay()
        {
            if (_hoursWorked <= 60 && _basePay > 8)
            {
                if (_hoursWorked <= 40)
                {
                    return _hoursWorked * _basePay;
                }

                return 40 * _basePay + (_hoursWorked - 40) * (_basePay * 1.5);
            }

            return 0;
        }

        public double CorrectTotalPay()
        {
            double employee = CalculateTotalPay();
            if (employee > 0)
            {
                return employee;
            }

            throw new IncorrectTotalPayException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double employee1 = TotalPay(7.5, 35);
            double employee2 = TotalPay(8.2, 47);
            double employee3 = TotalPay(10, 73);

            CorrectTotalPay(employee1);
            CorrectTotalPay(employee2);
            CorrectTotalPay(employee3);

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

                return 40 * basePay + (hoursWorked - 40) * (basePay * 1.5);
            }

            return 0;
        }

        public static void CorrectTotalPay(double employee)
        {
            if (employee > 0)
            {
                Console.WriteLine(employee);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}