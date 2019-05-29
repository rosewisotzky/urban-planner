using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are you hydrating plz remember to hydrate buddy it's a scorcher out there");

            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 40,
                Stories = 40,
                Height = 30,
                Depth = 3

            };
            Building CoolHome = new Building("44444 Paul Rigggaaal Blvd")
            {
                Width = 2,
                Stories = 100,
                Height = 5.5,
                Depth = 4
            };
            Building BigHouse = new Building("21 Lover's Lane")
            {
                Width = 25,
                Stories = 4,
                Height = 12,
                Depth = 100
            };

            List<Building> city = new List<Building>();
            city.Add(FiveOneTwoEigth);
            city.Add(CoolHome);
            city.Add(BigHouse);

            CoolHome.Purchase("Hank");
            FiveOneTwoEigth.Purchase("Angus");
            BigHouse.Purchase("Meag Mueller");
            foreach (Building building in city) 
            {
                building.DisplayDetails();
            }
        }
    }
}
