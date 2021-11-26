using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal meters = 2500;
            decimal hours = 5;
            decimal minutes = 56;
            decimal seconds = 23;
            decimal timeInSeconds = seconds + minutes * 60 + hours * 60 * 60;
            decimal timeInHours = hours + (minutes / 60) + seconds / 3600;

            decimal metersPerSecond = Math.Round(meters / timeInSeconds, 8);
            decimal kilometersPerhour = Math.Round(meters / 1000 / timeInHours, 8);
            decimal milesPerHour = Math.Round(meters / 1000 / 1.609m / timeInHours, 8);

            Console.WriteLine("Your speed in meters/second is " + metersPerSecond);
            Console.WriteLine("Your speed in km/h is " + kilometersPerhour);
            Console.WriteLine("Your speed in miles/h is " + milesPerHour);
            Console.ReadKey();
        }
    }
}
/*
Test Data
Input distance in meters: 2500 
Input hour: 5 
Input minutes: 56
Input seconds: 23
Expected Output :
Your speed in meters/second is 0.11691531 
Your speed in km/h is 0.42089513 
Your speed in miles/h is 0.26158804

 */