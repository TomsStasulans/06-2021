using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    internal class TestCar
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) * _liters;
        }
    }
}
