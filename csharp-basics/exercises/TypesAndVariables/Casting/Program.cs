using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Console.ReadKey();
        }

        static void First()
        {
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int sum = int.Parse(a) + b + c + Convert.ToInt32(d) + Convert.ToInt32(e);
            Console.WriteLine(sum);
        }

        static void Second()
        {
            string a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            float sum = float.Parse(a) + 
                float.Parse(b.ToString()) + 
                float.Parse(c.ToString()) + 
                float.Parse(d.ToString()) + 
                e;
            Console.WriteLine(sum);
        }
    }
}
