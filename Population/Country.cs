using System;
using System.Collections.Generic;
using System.Text;

namespace Population
{
    class Country
    {
        string _name;
        public uint TotalPopulation;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)))
                {
                    _name = value;
                }
            }
        }

        public Country(string name, uint totalPop):this(name)
        {
            if (Name != null)
            {
                TotalPopulation = totalPop;
            }
        }

        public Country(string name)
        {
            Name = name;
        }
    }
}
