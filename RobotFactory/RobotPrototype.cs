using System;
using System.Collections.Generic;
using System.Text;

public abstract class RobotPrototype
{
    public string modelName;
    public string batteryCapacity; // hours
    public string softwareVersion;

    public RobotPrototype(string modelName, string batteryCapacity, string softwareVersion)
    {
        this.modelName = modelName;
        this.batteryCapacity = batteryCapacity;
        this.softwareVersion = softwareVersion;
    }

    public abstract RobotPrototype Clone();
    public abstract void DisplayDetails();
}