
using System;

namespace Planner
{
    class Building
    {
        private string _designer = "Rose Ku'uleialoha Wisotzky";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address { get; set; }
        private string _owner { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        // This is our constructor below us!
        public Building(string address)
        {
            _address = address;
        }
        public string address { get; set; }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string name)
        {
            _owner = name;
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine($"---------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }

}