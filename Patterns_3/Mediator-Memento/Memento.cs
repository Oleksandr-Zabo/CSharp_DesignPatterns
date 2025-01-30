namespace Patterns_3.Mediator_Memento
{
    // Interface for Memento
    public interface IMemento
    {
        void SaveState(decimal balance);
        decimal RestoreState();
        void DisplayHistory();
    }

    // Memento class to save and restore BankAccount state
    public class Memento : IMemento
    {
        private readonly string _owner;
        private readonly List<decimal> _balanceHistory;

        public Memento(string owner, decimal initialBalance)
        {
            _owner = owner;
            _balanceHistory = new List<decimal> { initialBalance };
        }

        public void SaveState(decimal balance)
        {
            _balanceHistory.Add(balance);
        }

        public decimal RestoreState()
        {
            if (_balanceHistory.Count > 0)
            {
                return _balanceHistory.Last();
            }
            throw new InvalidOperationException("No state to restore.");
        }

        public void DisplayHistory()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{_owner}'s balance history:");
            foreach (var balance in _balanceHistory)
            {
                Console.WriteLine(balance);
            }
            Console.ResetColor();
        }
    }
}