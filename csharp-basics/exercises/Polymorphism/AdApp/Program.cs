using System;

namespace AdApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200, false));
            c.AddAdvert(new NewspaperAd(100, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, true));
            c.AddAdvert(new Poster(60, 30, 11, 150));
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}