using System;

namespace ConsoleApp5
{
    internal abstract class RobotPrototype
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        protected RobotPrototype(string modelName, int batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        public abstract RobotPrototype Clone();
        public abstract void DisplayInfo();
    }
}