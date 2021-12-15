using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            var yearlyResult = new Program();
            double energyDrinkers = yearlyResult.CalculateEnergyDrinkers(NumberedSurveyed);
            double PreferCitrus = yearlyResult.CalculatePreferCitrus(Convert.ToInt32(energyDrinkers));


            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + energyDrinkers + " bought at least one energy drink");
            Console.WriteLine(PreferCitrus + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        double CalculatePreferCitrus(int numberSurveyed)
        {
            return CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks;
        }
    }
}
