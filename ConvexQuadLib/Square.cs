using System;

namespace ConvexQuadLib
{
    public class Square : ConvexQuad
    {
        public Square() : base()
        {
        }

        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }
        public override double GetArea()
        {
            return Math.Pow(GetDistanceBetweenPoints(points[0], points[1]), 2);
        }
        public override void GetDiagonalsLength(out double d1, out double d2)
        {
            d1 = GetDistanceBetweenPoints(points[0], points[2]);
            d2 = d1;
        }
        public override double GetPerimeter()
        {
            return GetDistanceBetweenPoints(points[0], points[1]) * 4;
        }
        public override void GetAngles(out double angleA, out double angleB, out double angleC, out double angleD)
        {
            angleA = 90;
            angleB = 90;
            angleC = 90;
            angleD = 90;
        }

        public override void GetSides(out double a, out double b, out double c, out double d)
        {
            a = GetDistanceBetweenPoints(points[0], points[1]);
            b = a;
            c = a;
            d = a;
        }
    }
}
