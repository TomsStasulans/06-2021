using System;

namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string name, double money)
        {
            _money = money;
            _name = name;
        }

        public double Withdrawal(double i)
        {
            if (i < _money)
            {
                return _money -= i;
            }

            throw new Exception("Not enough money");
        }

        public void Deposit(double i)
        {
            if (i > 0)
            {
                _money += i;
            }
            else
            {
                throw new Exception("Enter number above 0");
            }
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public string Name => _name;
    }
}
