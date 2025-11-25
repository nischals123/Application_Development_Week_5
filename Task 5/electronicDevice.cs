using System;

public abstract class ElectronicDevice
{
    // Private fields
    private string brand;
    private double price;

    // Public properties (encapsulation)
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                Console.WriteLine("Price must be greater than 0.");
        }
    }

    // Constructor
    public ElectronicDevice(string brand, double price)
    {
        Brand = brand;
        Price = price;
    }

    // Abstract method
    public abstract void ShowInfo();
}