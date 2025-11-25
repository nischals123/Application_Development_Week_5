using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    // Add device
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to store.");
    }

    // Remove device
    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine($"{device.Brand} removed from store.");
    }

    // Show all device details
    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n All Devices in Store ");
        foreach (var device in devices)
        {
            device.ShowInfo();

            // Downcast to call child-specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}