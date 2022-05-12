using System;
using System.Collections;
using System.Collections.Generic;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<uint, City> cities = new SortedList<uint, City>();

            Country usa = new Country("USA", 334596450);
            City washington = new City("Washington", 689545, usa);
            City ny = new City("New York", 8804190, usa);
            City chicago = new City("Chicago", 2746388, usa);

            Country uk = new Country("United Kingdom", 67100000);
            City london = new City("London", 9002488, uk);
            City manchester = new City("Manchester", 547627, uk);

            cities.Add(washington.Population, washington);
            cities.Add(ny.Population, ny);
            cities.Add(chicago.Population, chicago);
            cities.Add(london.Population, london);
            cities.Add(manchester.Population, manchester);

            string minPopstr;
            uint minPop;
        inputMin:
            Console.WriteLine("Enter minimum population:");
            minPopstr = Console.ReadLine();
            
            if (UInt32.TryParse(minPopstr, out minPop))
            {
                minPop = Convert.ToUInt32(minPopstr);
            }
            else
            {
                Console.WriteLine("Input was not in correct type\n");
                goto inputMin;
            }
            
            string maxPopstr;
            uint maxPop;
        inputMax:
            Console.WriteLine("Enter maximum population:");
            maxPopstr = Console.ReadLine();

            if (UInt32.TryParse(maxPopstr, out maxPop))
            {
                maxPop = Convert.ToUInt32(maxPopstr);
            }
            else
            {
                Console.WriteLine("Input was not in correct type\n");
                goto inputMax;
            }

            Console.WriteLine();
            cities.FindAllByPopulation(minPop, maxPop);
        }
    }
}
