using System;

namespace Exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?:");
            decimal moneyInAccount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the annual interest rate:");
            decimal interestRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How long has the account been opened?");
            decimal monthsOpened = decimal.Parse(Console.ReadLine());

            SavingsAccount account = new SavingsAccount(moneyInAccount, interestRate);
            decimal totalDeposited = 0;
            decimal totalWithdrawn = 0;
            decimal interest = 0;

            for (int i = 1; i <= monthsOpened; i++)
            {
                Console.WriteLine("Enter amount deposited for month: {0}:", i);
                decimal deposited = decimal.Parse(Console.ReadLine());
                account.Deposited(deposited);
                totalDeposited += deposited;

                Console.WriteLine("Enter amount withdrawn for {0}:", i);
                decimal withDrawn = decimal.Parse(Console.ReadLine());
                account.Withdrawn(withDrawn);
                totalWithdrawn += withDrawn;
                interest = account.MonthlyInterest();
                account.AddingInterest();
            }

            Console.WriteLine("Total deposited: $" + Math.Round(totalDeposited, 2));
            Console.WriteLine("Total withdrawn: $" + Math.Round(totalWithdrawn, 2));
            Console.WriteLine("Interest earned: $" + Math.Round(interest, 2));
            Console.WriteLine("Ending balance: $" + Math.Round(account._balance, 2));
            Console.ReadKey();
        }
    }
}
