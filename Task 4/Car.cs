using System;

public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}