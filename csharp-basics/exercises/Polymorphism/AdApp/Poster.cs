namespace AdApp
{
    internal class Poster : Advert
    {
        public int _dimensions;
        public int _numberOfCopies;
        public int _costPerCopy;

        public Poster(int fee, int dimensions, int numberOfCopies, int costPerCopy) : base(fee)
        {
            _dimensions = dimensions;
            _numberOfCopies = numberOfCopies;
            _costPerCopy = costPerCopy;
        }

        public override int Cost()
        {
            return base.Cost() + _dimensions * _numberOfCopies * _costPerCopy;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
