namespace Exercise_9
{
    internal class Point
    {
        public int _x;
        public int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point SwapPoints(Point p1, Point p2)
        {
            int tempX = p1._x;
            int tempY = p1._y;
            p1._x = p2._x;
            p1._y = p2._y;
            p2._x = tempX;
            p2._y = tempY;
            return this;
        }
    }
}
