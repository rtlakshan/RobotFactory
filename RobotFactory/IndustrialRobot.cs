using System;
using System.Collections.Generic;
using System.Text;

public class IndustrialRobot : RobotPrototype
{
    public string industrialTask;

    public IndustrialRobot(string modelName, string batteryCapacity,
        string softwareVersion, string industrialTask)
        : base(modelName, batteryCapacity, softwareVersion)
    {
        this.industrialTask = industrialTask;
    }

    public override RobotPrototype Clone()
    {
        return new IndustrialRobot(this.modelName, this.batteryCapacity,
            this.softwareVersion, this.industrialTask);
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"IndustrialRobot: {modelName} {batteryCapacity}h {softwareVersion} {industrialTask}");
    }
}
