using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            p1.SwapPoints(p1, p2);
            Console.WriteLine("(" + p1._x + ", " + p1._y + ")");
            Console.WriteLine("(" + p2._x + ", " + p2._y + ")");
            Console.ReadKey();
        }
    }
}
