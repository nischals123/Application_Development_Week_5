
class Program
{
    static void Main(string[] args)
    {
        // Creating bank account object
        BankAccount account = new BankAccount("ACCOUNT123", 4000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);

        // Deposit money
        account.Deposit(2000);

        // Withdraw money
        account.Withdraw(1500);

        // Print remaining balance
        Console.WriteLine("Remaining Balance: " + account.Balance);
    }
}