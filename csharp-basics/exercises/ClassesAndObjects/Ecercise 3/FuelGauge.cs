using System;

namespace Ecercise_3
{
    public class FuelGauge
    {
        public double _liters { get; set; }

        public FuelGauge(double liters)
        {
            _liters = liters;
        }

        public void ReportLiters()
        {
            Console.WriteLine(_liters);
        }

        public double IncrementFuel()
        {
            if (_liters < 70)
            {
                return _liters++;
            }
            else
            {
                return 70;
            }
        }

        public double DecrementFuel()
        {
            if (_liters > 0)
            {
                return _liters--;
            }
            else
            {
                return 0;
            }
        }
    }
}
