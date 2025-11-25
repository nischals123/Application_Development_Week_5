public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price) { }

    // Extra method
    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera is enabled.");
    }

    // Override ShowInfo
    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}, Price: ${Price}");
    }
}