using System;

namespace Ecercise_3
{
    public class FuelGauge
    {
        public double Liters { get; set; }

        public FuelGauge(double liters)
        {
            Liters = liters;
        }

        public void ReportLiters()
        {
            Console.WriteLine(Liters);
        }

        public double IncrementFuel()
        {
            if (Liters < 70)
            {
                return Liters++;
            }
            else
            {
                return 70;
            }
        }

        public double DecrementFuel()
        {
            if (Liters > 0)
            {
                return Liters--;
            }
            else
            {
                return 0;
            }
        }
    }
}
