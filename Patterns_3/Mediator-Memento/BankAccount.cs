namespace Patterns_3.Mediator_Memento
{
    // BankAccount class represents a user's bank account.
    public class BankAccount
    {
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }

        // Memento object to handle state saving and restoring.
        private IMemento _memento;

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
            _memento = new Memento(owner, initialBalance);
            _memento.SaveState(Balance); // Save initial state.
        }

        // Deposit money into the account.
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _memento.SaveState(Balance); // Save state after deposit.
        }

        // Withdraw money from the account.
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
            Balance -= amount;
            _memento.SaveState(Balance); // Save state after withdrawal.
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
            _memento.SaveState(Balance); // Save state after transfer.
        }

        // Restore the account to the last saved state.
        public void RestoreState()
        {
            Balance = _memento.RestoreState(); // Restore state from Memento.
        }

        // Display account information.
        public override string ToString()
        {
            return $"{Owner}'s account balance: {Balance}";
        }

        // Display history of snapshots.
        public void DisplayHistory()
        {
            _memento.DisplayHistory(); // Delegate to Memento.
        }
    }
}