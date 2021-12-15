using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(20);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
            Console.WriteLine();

            Account tomsAccount = new Account("Toms account", 100.00);
            tomsAccount.Deposit(20);
            Console.WriteLine(tomsAccount);
            Console.WriteLine();

            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);
            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);
            Transfer(A, B, 50);
            Transfer(A, C, 25);
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}
