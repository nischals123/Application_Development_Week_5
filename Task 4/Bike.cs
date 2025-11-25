using System;

public class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }
}