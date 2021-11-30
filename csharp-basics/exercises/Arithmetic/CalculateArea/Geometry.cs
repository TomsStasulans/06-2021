using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            return Math.PI * (double)radius * 2;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            double area = (double)length * (double)width;
            return area;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            return (double)ground * (double)h * 0.5;
        }
    }
}
