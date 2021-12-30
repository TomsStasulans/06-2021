using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.PI * Math.Pow((double)radius, 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            return (double)(length * width);
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return (double)(ground * h) * 0.5;
        }
    }
}
