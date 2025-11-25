using System;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        // Create Laptop and Smartphone objects
        Laptop laptop1 = new Laptop("Aser", 1200);
        Smartphone phone1 = new Smartphone("Samsung24", 800);

        // Add devices to store
        store.AddDevice(laptop1);
        store.AddDevice(phone1);

        // Display all devices and child-specific behavior
        store.ShowAllDeviceDetails();
    }
}