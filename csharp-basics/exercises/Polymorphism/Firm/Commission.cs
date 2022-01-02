namespace Firm
{
    internal class Commission : Hourly
    {
        private double _totalSales { get; set; }
        private double _commissionRate { get; set; }

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) 
        : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = _totalSales + totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _totalSales * _commissionRate;
            return payment;
        }
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            result += "\nCommission from sales: " + _totalSales * _commissionRate;
            return result;
        }
    }
}
