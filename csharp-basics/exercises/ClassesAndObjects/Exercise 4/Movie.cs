namespace Exercise_4
{
    internal class Movie
    {
        private string _title { get; set; }
        private string _studio { get; set; }
        public string _rating { get; private set; }

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }
    }
}
