using System;


using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ROBOT FACTORY PROTOTYPE SYSTEM ===\n");

            
            ServiceRobot originalService = new ServiceRobot("CareBot", 12, "1.0", "Hospital Assistance");
            ServiceRobot clonedService = (ServiceRobot)originalService.Clone();
            clonedService.BatteryCapacity = 18;
            clonedService.SoftwareVersion = "1.2"; 
            
            IndustrialRobot originalIndustrial = new IndustrialRobot("WeldMaster", 24, "2.0", "Welding");
            IndustrialRobot clonedIndustrial = (IndustrialRobot)originalIndustrial.Clone();
            clonedIndustrial.IndustrialTask = "Assembly"; 

            EntertainmentRobot originalEntertainment = new EntertainmentRobot("FunBot", 8, "1.0", "Dancing");
            EntertainmentRobot clonedEntertainment = (EntertainmentRobot)originalEntertainment.Clone();
            clonedEntertainment.SoftwareVersion = "2.0";

           
            clonedService.DisplayInfo();
            clonedIndustrial.DisplayInfo();
            clonedEntertainment.DisplayInfo();
        }
    }
}