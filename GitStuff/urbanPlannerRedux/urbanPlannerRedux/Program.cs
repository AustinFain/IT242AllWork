using System;

namespace UrbanPlanner5
{
    class Program
    {
        static void Main(string[] args)
        {
            Building MCTC = new Building("1 Moutwest Way", "ClevCo Construction LLC.")
            {
                Width = 100,
                Depth = 200,
                NumberOfStories = 4
            };
            Building ClevCoBuilding = new Building("ClevCo", "Austin Fain Clevenger")
            {
                Width = 1000,
                Depth = 250,
                NumberOfStories = 6
            };
            Building MilkStation = new Building("SPACE", "ClevCo")
            {
                Width = 10,
                Depth = 50,
                NumberOfStories = 1
            };

            MCTC.Construct();
            ClevCoBuilding.Construct();
            MilkStation.Construct();
            MCTC.Purchase("Austin Clevenger");
            ClevCoBuilding.Purchase("ClevCo");
            MilkStation.Purchase("King of Space");

            MCTC.DisplayBuildingInfo();
            ClevCoBuilding.DisplayBuildingInfo();
            MilkStation.DisplayBuildingInfo();






            Console.WriteLine("");
        }
    }
}