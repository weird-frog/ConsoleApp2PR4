using System;

namespace ConvexQuadLib
{
    public class Rhombus : ConvexQuad
    {
        public Rhombus() : base() 
        { 
        }
        public Rhombus(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }

        public override double GetArea()
        {
            double d1, d2;
            GetDiagonalsLength(out d1, out d2);
            return (d1 * d2) / 2d;
        }

        public override void GetDiagonalsLength(out double d1, out double d2)
        {
            d1 = GetDistanceBetweenPoints(points[0], points[2]);
            d2 = GetDistanceBetweenPoints(points[3], points[1]);
        }
        public override double GetPerimeter()
        {
            return GetDistanceBetweenPoints(points[0], points[1]) * 4;
        }
        public override void GetAngles(out double angleA, out double angleB, out double angleC, out double angleD)
        {
            double d = GetDistanceBetweenPoints(points[0], points[2]),
                a = GetDistanceBetweenPoints(points[0], points[1]);
            double ang = Math.Acos((d * d) / (2 * (a * a)) - 1) * 180 / Math.PI;
            angleA = ang;
            angleB = (360 - ang * 2d) / 2d;
            angleC = angleA;
            angleD = angleB;

        }
    }
}

