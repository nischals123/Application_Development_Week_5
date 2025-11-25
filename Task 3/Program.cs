class Program
{
    static void Main(string[] args)
    {
        // -------- Printer Class Testing --------
        Printer printer = new Printer();
        printer.Print("Hello Students");
        printer.Print(20);
        printer.Print("Repeat This", 3);

        Console.WriteLine("\n--- Teacher Classes ---");

        // NepaliTeacher object
        NepaliTeacher nepali = new NepaliTeacher();
        nepali.Name = "Nischal Shrestha";
        Console.WriteLine("Teacher Name: " + nepali.Name);
        nepali.Teaching();     // Overridden method
        nepali.SalaryInfo();   // Sealed method

        Console.WriteLine();

        // EnglishTeacher object
        EnglishTeacher english = new EnglishTeacher();
        english.Name = "Pardip";
        Console.WriteLine("Teacher Name: " + english.Name);
        english.Teaching();    // Inherited method
        english.SalaryInfo();  // Sealed method
    }
}