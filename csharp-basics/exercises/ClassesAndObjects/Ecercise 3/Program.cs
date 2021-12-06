using System;

namespace Ecercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Odometer myOdo = new Odometer(400);
            FuelGauge myTank = new FuelGauge(3);
            myTank.IncrementFuel();

            while(myTank._liters != 0)
            {
                myOdo.IncrementMileage();

                if(myOdo._mileage % 10 == 0)
                {
                    myTank.DecrementFuel();
                }

                myTank.ReportLiters();
                myOdo.Mileage();
            }
            
            Console.ReadKey();
        }
    }
}
