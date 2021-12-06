using System.Collections.Generic;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var casinoRoyal = new Movie("Casino Royale", "Eon Productions", "PG13");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
        }

        public static Movie[] GetPG(Movie[] movies)
        {
            var filtered = new List<Movie>();
            foreach (Movie movie in movies)
            {
                if (movie._rating == "PG")
                {
                    filtered.Add(movie);
                }
            }

            return filtered.ToArray();
        }
    }
}
