using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account((decimal)17.25, "Benson");
            Account toms = new Account((decimal)-17.2, "TTTT");
            Account fredis = new Account(17, "TTT");

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.WriteLine(toms.ShowUserNameAndBalance());
            Console.WriteLine(fredis.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
