using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ConsoleApp5
{
    internal class IndustrialRobot : RobotPrototype
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Industrial Robot] Model: {ModelName} | Battery: {BatteryCapacity}h | Version: v{SoftwareVersion} | Task: {IndustrialTask}");
        }
    }
}