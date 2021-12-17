namespace AdApp
{
    public class Hoarding: Advert
    {
        private int _rate;
        private int _numDays;
        private bool _primeLocation;

        public Hoarding(int fee, int rate, int numDays, bool primeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
            _primeLocation = primeLocation;
        }

        public override int Cost() 
        {
            if(_primeLocation)
            {
                return (_numDays * _rate) * 2 + base.Cost();
            }
            else
            {
                return _numDays * _rate + base.Cost();
            }
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}