using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                double currentMilage = myOdo._mileage;
                if(currentMilage % 10 == 0)
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
