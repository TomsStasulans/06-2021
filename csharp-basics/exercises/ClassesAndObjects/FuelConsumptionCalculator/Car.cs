using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers { get; set; }
        private double _endKilometers { get; set; }
        private double _liters { get; set; }

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return ((_endKilometers - _startKilometers) / 100) * _liters;
        }

        private double ConsumptionPer100Km()
        {
            return ((_endKilometers - _startKilometers) / 100) * _liters;
        }

        public bool GasHog()
        {
            return CalculateConsumption() > 15;
        }

        public bool EconomyCar()
        {
            return CalculateConsumption() < 5.0;
        }

        public void FillUp(int mileage, double liters)
        {
            _liters = liters;
            _endKilometers = mileage;
        }
    }
}
