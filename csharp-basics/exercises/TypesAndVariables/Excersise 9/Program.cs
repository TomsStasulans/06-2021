using System;

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