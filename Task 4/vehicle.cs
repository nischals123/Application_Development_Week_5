using System;

public abstract class Vehicle
{
    // Abstract methods
    public abstract void StartEngine();
    public abstract void StopEngine();

    // Concrete method
    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}