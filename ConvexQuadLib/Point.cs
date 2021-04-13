namespace ConvexQuadLib
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }
    }
}
