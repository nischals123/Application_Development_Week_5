public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public void SalaryInfo()
    {
        Console.WriteLine("Salary information is confidential.");
    }
}

public class NepaliTeacher : Teacher
{
    // Overriding Teaching() method
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali language");
    }
}

public class EnglishTeacher : Teacher
{
    // No need to override Teaching()
    // It will use the base class method
}