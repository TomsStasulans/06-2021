using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> cars = new List<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            HashSet<string> hashCars = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            foreach (string car in hashCars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine();

            Dictionary<string, string> dicCars = new Dictionary<string, string>();
            dicCars.Add("Audi", "Germany");
            dicCars.Add("BMW", "Germany");
            dicCars.Add("Honda", "Japan");
            dicCars.Add("Mercedes", "Germany");
            dicCars.Add("VolsWagen", "Germany");
            dicCars.Add("Tesla", "USA");

            foreach (var car in dicCars)
            {
                Console.WriteLine(car.Key + " " + car.Value);
            }

            Console.ReadKey();
        }
    }
}
