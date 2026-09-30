using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ConsoleApp5
{
    internal class ServiceRobot : RobotPrototype
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override RobotPrototype Clone()
        {
            return (RobotPrototype)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Service Robot] Model: {ModelName} | Battery: {BatteryCapacity}h | Version: {SoftwareVersion} | Task: {ServiceTask}");
        }
    }
}