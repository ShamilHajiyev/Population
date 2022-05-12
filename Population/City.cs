using System;
using System.Collections.Generic;
using System.Text;

namespace Population
{
    class City
    {
        string _name;
        public uint Population;
        Country _country;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) || true)
                {
                    _name = value;
                }
            }
        }

        public Country Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public City(string name, uint pop, Country country):this(name, country)
        {
            if (name != null && Population < Country.TotalPopulation)
            {
                Population = pop;
            }
        }

        public City(string name, Country country)
        {
            Country = country;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
