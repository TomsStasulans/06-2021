namespace BankAccount
{
    internal class Account
    {
        private decimal _balance;
        private string _name;

        public Account(decimal balance, string name)
        {
            _balance = balance;
            _name = name;
        }

        public string ShowUserNameAndBalance()
        {
            string stringBalance = _balance.ToString("0.00#######");
            if (_balance > 0)
            {
                return _name + ", $" + stringBalance;
            }
            else
            {
                _balance *= -1;
                return _name + ", -$" + stringBalance;
            }
        }
    }
}
