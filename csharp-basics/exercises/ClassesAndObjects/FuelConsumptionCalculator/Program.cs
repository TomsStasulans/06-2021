using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = int.Parse(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = int.Parse(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                
                Console.Write("Enter first reading: ");
                startKilometers = int.Parse(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = int.Parse(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption()+ " economyCar:" + car.EconomyCar());
            Console.ReadKey();
        }
    }
}
