public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property (only get)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property for Balance (get only, set private)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("Balance cannot be negative.");
            }
            else
            {
                balance = value;
            }
        }
    }

    // Constructor
    public BankAccount(string accNum, double openingBalance)
    {
        accountNumber = accNum;
        Balance = openingBalance;   // calls the private setter
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount should be greater than 0.");
        }
        else
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
    }
}