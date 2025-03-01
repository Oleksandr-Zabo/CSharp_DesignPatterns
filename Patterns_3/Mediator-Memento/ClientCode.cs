﻿namespace Patterns_3.Mediator_Memento
{
    public class ClientCode
    {
        public void Main()
        {
            // Create bank accounts.
            var account1 = new BankAccount("Alice", 1000);
            var account2 = new BankAccount("Bob", 500);

            // Create the mediator.
            var bankMediator = new BankMediator();
            bankMediator.RegisterAccount(account1);
            bankMediator.RegisterAccount(account2);

            // Display initial balances.
            Console.WriteLine(account1);
            Console.WriteLine(account2);

            // Perform a transfer using the mediator.
            bankMediator.Transfer("Alice", "Bob", 200);
            Console.WriteLine(account1);
            Console.WriteLine(account2);

            // Withdraw money from Alice's account.
            account1.Withdraw(300);
            Console.WriteLine(account1);

            // Restore Alice's account to the previous state using Memento.
            account1.RestoreState(); // Restore to the last saved state.
            Console.WriteLine(account1);

            // Display history of snapshots for Alice's account.
            account1.DisplayHistory();
        }
    }
}