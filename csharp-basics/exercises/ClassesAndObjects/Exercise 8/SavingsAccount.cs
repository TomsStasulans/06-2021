namespace Exercise_8
{
    internal class SavingsAccount
    {
        private decimal _anualInterestRate { get; set; }
        public decimal _balance { get; set; }
        private decimal _monthlyInterest { get; set; }

        public SavingsAccount(decimal balance, decimal anualInterestRate)
        {
            _balance = balance;
            _anualInterestRate = anualInterestRate;
        }

        public decimal Withdrawn(decimal substractMoney)
        {
            return _balance -= substractMoney;
        }

        public decimal Deposited(decimal addMoney)
        {
            return _balance += addMoney;
        }

        public decimal AddingInterest()
        {
            return _balance += MonthlyInterest();
        }

        public decimal MonthlyInterest()
        {
            return (_anualInterestRate / 12) * _balance;
        }
    }
}
