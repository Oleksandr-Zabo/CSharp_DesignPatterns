namespace Patterns_3.Mediator_Memento
{
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
            BankAccount fromAccount = null;
            BankAccount toAccount = null;

            // Find accounts without LINQ.
            foreach (var account in _accounts)
            {
                if (account.Owner == fromOwner)
                {
                    fromAccount = account;
                }
                if (account.Owner == toOwner)
                {
                    toAccount = account;
                }
            }

            if (fromAccount == null || toAccount == null)
            {
                throw new InvalidOperationException("One of the accounts does not exist.");
            }

            fromAccount.Transfer(toAccount, amount);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Mediator] Transferred {amount} from {fromOwner} to {toOwner}.");
            Console.ResetColor();
        }
    }
}