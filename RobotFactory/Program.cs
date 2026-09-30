using System;

public class Program
{
    public static void Main(String[] args)
    {
        ServiceRobot careBot = new ServiceRobot("CareBot-X", "8", "v1.0", "Patient assistance");
        careBot.DisplayDetails();

        ServiceRobot careBotPlus = (ServiceRobot)careBot.Clone();
        careBotPlus.batteryCapacity = "10";
        careBotPlus.softwareVersion = "v1.2";
        careBotPlus.DisplayDetails();

        IndustrialRobot weldBot = new IndustrialRobot("WeldMaster-500", "12", "v2.1", "Welding");
        weldBot.DisplayDetails();

        IndustrialRobot assemblyBot = (IndustrialRobot)weldBot.Clone();
        assemblyBot.industrialTask = "Assembly";
        assemblyBot.DisplayDetails();

        EntertainmentRobot funBot = new EntertainmentRobot("FunBot-Pro", "6", "v1.5", "Interactive dancing");
        funBot.DisplayDetails();

        EntertainmentRobot storyBot = (EntertainmentRobot)funBot.Clone();
        storyBot.entertainmentFeature = "Storytelling";
        storyBot.DisplayDetails();
    }
}