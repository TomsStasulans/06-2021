namespace Exercise_5
{
    public class Date
    {
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        private int _year { get; set; }
        private int _month { get; set; }
        private int _day { get; set; }

        public string DisplayDate()
        {
            return $"{_month}/{_day}/{_year}";
        }
    }
}
