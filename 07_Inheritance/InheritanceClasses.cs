using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance
{
    abstract class House
    {

        public string TypeOfHouse { get; set; }
        public int NumberOfBedrooms { get; set; }
        public int NumberOfBathrooms { get; set; }

        public House() { }

        public House (string typeOfHouse, int numberOfBedrooms, int numberOfBathrooms)
        {
            TypeOfHouse = typeOfHouse;
            NumberOfBedrooms = numberOfBedrooms;
            NumberOfBathrooms = numberOfBathrooms;
        }

    }

    class Bedroom : House
    {
        public bool Main { get; set; }
        public bool Kids { get; set; }
        public bool InLaw { get; set; }

    }

    class Bathrooms : House
    {
        public bool FullBath { get; set; }
        public bool HalfBath { get; set; }

    }

    class Basement : House
    {
        public bool FinishedBasement { get; set; }
    }
}
