namespace Patterns_3.Mediator_Memento
{
    // Memento Pattern: Represents a snapshot of the bank account state.
    public class AccountMemento
    {
        public decimal Balance { get; private set; }
        public DateTime SnapshotDate { get; private set; }
        public string Owner { get; private set; }

        public AccountMemento(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
            SnapshotDate = DateTime.Now;
        }

        // Display memento details.
        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[Memento] Snapshot for {Owner}'s account:");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Date: {SnapshotDate}");
            Console.ResetColor();
        }
    }
}