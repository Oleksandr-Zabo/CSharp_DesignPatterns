namespace Patterns_3.Mediator_Memento;

// BankAccount class represents a user's bank account.
public class BankAccount
{
    public string Owner { get; private set; }
    public decimal Balance { get; private set; }

    // List to store all snapshots
    private List<AccountMemento> _history = new List<AccountMemento>();

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
        SaveState(); // Save initial state.
    }

    // Deposit money into the account.
    public void Deposit(decimal amount)
    {
        Balance += amount;
        SaveState(); 
    }

    // Withdraw money from the account.
    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        Balance -= amount;
        SaveState(); 
    }

    // Transfer money to another account.
    public void Transfer(BankAccount targetAccount, decimal amount)
    {
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        Withdraw(amount);
        targetAccount.Deposit(amount);
        SaveState(); 
    }

    // Memento Pattern: Save the current state of the account.
    public AccountMemento SaveState()
    {
        var memento = new AccountMemento(Balance);
        _history.Add(memento); // Add to history
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"State saved for {Owner}'s account. Balance: {Balance}");
        Console.ResetColor();
        return memento;
    }

    // Memento Pattern: Restore the account to a previous state.
    public void RestoreState(AccountMemento memento)
    {
        Balance = memento.Balance;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"State restored for {Owner}'s account. Balance: {Balance}");
        Console.ResetColor();
    }

    // Display account information.
    public override string ToString()
    {
        return $"{Owner}'s account balance: {Balance}";
    }
}
