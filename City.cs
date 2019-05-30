using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string CityName { get; set; }
        public string MayorName { get; set; }
        public int YearEst { get; set; }
        public List<Building> buildingList { get; set; } = new List<Building>();
        // This method called addBuilding takes the Building we're constructing as the argument and adds that to the public method above called buildingList.
        public void AddBuilding(Building building)
        {
            buildingList.Add(building);
        }
        public void DisplayCityDetails() {
            Console.WriteLine($"Welcome to {CityName}, est. {YearEst}. Our mayor is {MayorName} Check out this building!");
        }
    }
}