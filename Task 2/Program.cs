
public class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} is starting...");
    }

    public void Stop()
    {
        Console.WriteLine($"{Brand} is stopping...");
    }

    // Virtual method (so child classes can override)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

// Derived Class 1
public class Car : Vehicle
{
    public int Seats { get; set; }  // Unique field

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Seats: {Seats}");
    }
}

// Derived Class 2
public class Motorcycle : Vehicle
{
    public bool HasCarrier { get; set; }  // Unique field

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Carrier: {HasCarrier}");
    }
}