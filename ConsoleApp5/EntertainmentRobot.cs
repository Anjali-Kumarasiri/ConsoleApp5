using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ConsoleApp5
{
    internal class EntertainmentRobot : RobotPrototype
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Entertainment Robot] Model: {ModelName} | Battery: {BatteryCapacity}h | Version: v{SoftwareVersion} | Feature: {EntertainmentFeature}");
        }
    }
}