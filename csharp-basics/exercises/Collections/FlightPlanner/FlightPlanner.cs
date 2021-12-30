using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightPlanner
{
    public class FlightPlanner
    {
        public string DisplayCities(List<string> cities)
        {
            return string.Join(" ", cities);
        }

        public List<string> FlightsToList(string[] text)
        {
            return text.ToList();
        }

        public string[] SplitRoute(string cities)
        {
            return cities.Split(new string[] { " -> " }, StringSplitOptions.None);
        }

        public HashSet<string> AddCitiesToHashset(string[] readText)
        {
            var result = new HashSet<string>();
            foreach (string flight in readText)
            {
                string[] cities = SplitRoute(flight);
                result.Add(cities[0]);
                result.Add(cities[1]);
            }

            return result;
        }
    }
}