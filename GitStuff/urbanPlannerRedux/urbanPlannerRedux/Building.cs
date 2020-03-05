using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner5
{
    class Building
    {
        
        private string DesingnerName { get; set; }
        
        private DateTime DateConstructed { get; set; }
        
        private string BuildingAddress { get; set; }
      
        private string BuildingOwner { get; set; }

        
        public int NumberOfStories { get; set; }
        
        public double Width { get; set; }
        
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * NumberOfStories);
            }
        }

 
        public Building(string address, string designer)
        {
            BuildingAddress = address;
            DesingnerName = designer;

        }
 
        public void Construct()
        {
            DateConstructed = DateTime.Now;
        }
  
        public void Purchase(string buyer)
        {
            BuildingOwner = buyer;
        }

        public void DisplayBuildingInfo()
        {
            Console.WriteLine(BuildingAddress);
            Console.WriteLine("--------------");
            Console.WriteLine("Designed by " + DesingnerName);
            Console.WriteLine("Date Constructed " + DateConstructed);
            Console.WriteLine("Owned by " + BuildingOwner);
            Console.WriteLine(Volume + " cubic meteres of space");
        }



    }
}