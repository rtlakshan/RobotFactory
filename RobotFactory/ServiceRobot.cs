using System;
using System.Collections.Generic;
using System.Text;

public class ServiceRobot : RobotPrototype
{
    public string serviceTask;

    public ServiceRobot(string modelName, string batteryCapacity,
        string softwareVersion, string serviceTask)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        this.serviceTask = serviceTask;
    }

    public override RobotPrototype Clone()
    {
        return new ServiceRobot(this.modelName, this.batteryCapacity,
            this.softwareVersion, this.serviceTask);
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"ServiceRobot: {modelName} {batteryCapacity}h {softwareVersion} {serviceTask}");
    }
}
