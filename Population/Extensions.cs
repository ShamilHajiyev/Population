using System;
using System.Collections.Generic;
using System.Text;

namespace Population
{
    static class Extensions
    {
        public static void FindAllByPopulation(this SortedList<uint, City> cities, uint min, uint max)
        {
            bool output = false;
            foreach (var city in cities)
            {
                if (city.Key < max && city.Key > min)
                {
                    output = true;
                    Console.WriteLine($"{city.Value.ToString()} - {city.Key}");
                }
            }
            if (!output)
            {
                Console.WriteLine("No city found for your request");
            }
        }
    }
}
