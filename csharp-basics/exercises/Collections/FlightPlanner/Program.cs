using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = @"C:\Projects\06-2021\csharp-basics\exercises\Collections\FlightPlanner\flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            List<string> flightInfo = new List<string>();
            FlightsToList(readText, flightInfo);
            List<string> roundTrip = new List<string>();

            HashSet<string> allCities = new HashSet<string>();
            foreach (string flight in readText)
            {
                string[] cities = SplitRoute(flight);
                allCities.Add(cities[0]);
                allCities.Add(cities[1]);

            }

            while (true)
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("To display list of the cities press 1");
                Console.WriteLine("To exit program press #");
                var character = Console.ReadKey();
                char option = character.KeyChar;

                switch (option)
                {
                    case '#':
                        return;
                    case '1':
                        DisplayCities(flightInfo);
                        break;
                    default:
                        return;
                }

                Console.WriteLine("To select a city from which you would like to start press 1");
                Console.WriteLine("To exit program press #");
                var secondChar = Console.ReadKey();
                char secondOption = secondChar.KeyChar;

                switch (secondOption)
                {
                    case '#':
                        return;
                    case '1':
                        foreach (var city in allCities)
                        {
                            Console.WriteLine(city);
                        }
                        break;
                    default:
                        return;
                }

                while (true)
                {
                    if(roundTrip.Count == 0)
                    {
                        Console.WriteLine("Enter the city you would like to fly from");
                    }
                    else
                    {
                        Console.WriteLine("Enter the city you would like to fly to");
                    }

                    Console.WriteLine("To exit program press #");
                    string inputCity = Console.ReadLine();

                    if (inputCity == "#")
                    {
                        return;
                    }

                    if (!roundTrip.Contains(inputCity))
                    {
                        roundTrip.Add(inputCity);
                        foreach (string flight in readText)
                        {
                            string[] cities = SplitRoute(flight);
                            if (cities[0] == inputCity)
                            {
                                Console.WriteLine(cities[1]);
                            }
                        }
                    }
                    else
                    {
                        roundTrip.Add(inputCity);
                        Console.WriteLine("Your route will be: ");
                        DisplayCities(roundTrip);
                        return;
                    }
                }
            }

            Console.ReadKey();
        }

        private static void DisplayCities(List<string> cities)
        {
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void FlightsToList(string[] text, List<string> list)
        {
            foreach (var s in text)
            {
                list.Add(s);
            }
        }

        private static string[] SplitRoute(string cities)
        {
            return cities.Split(new string[] { " -> " }, StringSplitOptions.None);
        }
    }
}
