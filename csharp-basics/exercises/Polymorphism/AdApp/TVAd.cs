namespace AdApp
{
    public class TVAd: Advert
    {
        private int _seconds;
        private bool _peekTime;
        private int _timeShown;

        public TVAd(int fee, int timeShown, int seconds, bool peekTime) : base(fee)
        {
            _timeShown = timeShown;
            _seconds = seconds;
            _peekTime = peekTime;
        }

        public override int Cost() 
        {
            if(_peekTime)
            {
                return (base.Cost() + _seconds * _timeShown) * 2;
            }
            else
            {
                return base.Cost() + _seconds * _timeShown;
            }
        }

        private int SetFee(object fee)
        {
            return base.Cost() + int.Parse(fee.ToString());
        }

        public override string ToString() 
        {
            return base.ToString();
        }
    }
}