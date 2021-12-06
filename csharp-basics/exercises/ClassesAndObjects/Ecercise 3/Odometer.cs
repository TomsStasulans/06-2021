using System;

namespace Ecercise_3
{
    class Odometer
    {
        public double _mileage { get; set; }

        public Odometer(double mileage)
        {
            _mileage = mileage;
        }

        public void Mileage()
        {
            Console.WriteLine(_mileage); 
        }

        public double IncrementMileage()
        {
            if (_mileage < 999999)
            {
                return _mileage++;
            }
            else
            {
                return 0;
            }
        }
    }
}
