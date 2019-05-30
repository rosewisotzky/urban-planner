// In this file we have our class of Building. 
using System;

namespace Planner
{
    // Wow, will you look at that! There's our class creating the type Building. Let's take a closer look at what we've got goin' on in here.
    class Building
    {
        // Here are our private fields. These can only be accessed within this class. If we try to use them outside of it, we're gonna get scolded and told to mind our own business.
        private string _designer = "Rose Ku'uleialoha Wisotzky";
        private DateTime _dateConstructed = DateTime.Now;
        // In each field we're saying which type it is, and the name and then getting the value of the field and setting the value of the field. That basically just means that it's read and write so you can change it AND see it. Wowza!
        private string _address { get; set; }
        private string _owner { get; set; }
        // Here are our public properties. Again, we're specifying the type and allowing it to be read-write. These are the properties of our class, so we have things like how many stories, the width, etc.
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
        // This is our constructor below us! We are setting field value of _address to the string address that we're passing in as our argument.
        public Building(string address)
        {
            _address = address;
        }
        public string address { get; set; }

        // The public method called Construct allows us to set the field value of _dateConstructed to the current time when we call this method.
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        // The public method named Purchase allows us to set the field value of _owner to the name passed in as the argument when we call this method.
        public void Purchase(string name)
        {
            _owner = name;
        }
        // Our public method DisplayDetails allows us to print out the field and property values all at once, instead of calling them individually in Program.cs
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