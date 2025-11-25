class Program
{
    static void Main(string[] args)
    {
        // Creating object of Car
        Car car = new Car();
        car.Brand = "Shikhhh";
        car.Speed = 120;
        car.Seats = 5;

        // Creating object of Motorcycle
        Motorcycle bike = new Motorcycle();
        bike.Brand = "puslar";
        bike.Speed = 40;
        bike.HasCarrier = true;

        // Calling methods from base class
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}