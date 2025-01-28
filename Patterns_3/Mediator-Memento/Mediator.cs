namespace Patterns_3.Mediator_Memento;

// Mediator Pattern: Manages interactions between bank accounts.
public class BankMediator
{
    private List<BankAccount> _accounts = new List<BankAccount>();

    // Register a new account with the mediator.
    public void RegisterAccount(BankAccount account)
    {
        _accounts.Add(account);
    }

    // Transfer money between two accounts.
    public void Transfer(string fromOwner, string toOwner, decimal amount)
    {
        var fromAccount = _accounts.FirstOrDefault(a => a.Owner == fromOwner);
        var toAccount = _accounts.FirstOrDefault(a => a.Owner == toOwner);

        if (fromAccount == null || toAccount == null)
        {
            throw new InvalidOperationException("One of the accounts does not exist.");
        }

        fromAccount.Transfer(toAccount, amount);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Transferred {amount} from {fromOwner} to {toOwner}.");
        Console.ResetColor();
    }
}