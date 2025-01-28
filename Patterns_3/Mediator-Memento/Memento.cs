namespace Patterns_3.Mediator_Memento;

// Memento Pattern: Represents a snapshot of the bank account state.
public class AccountMemento
{
    public decimal Balance { get; private set; }

    public AccountMemento(decimal balance)
    {
        Balance = balance;
    }
}