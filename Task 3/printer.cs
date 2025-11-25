public class Printer
{
    // Overload 1: Print string message
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    // Overload 2: Print integer number
    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    // Overload 3: Print message multiple times
    public void Print(string message, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine($"{i}. {message}");
        }
    }
}