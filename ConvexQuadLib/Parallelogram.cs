using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvexQuadLib
{
    public class Parallelogram : ConvexQuad
    {
        public Parallelogram() : base() { }

        public Parallelogram(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4) : base(x1, y1, x2, y2, x3, y3, x4, y4)
        {
        }

        public override double GetArea()
        {
            return Math.Abs((points[0].X * points[3].Y) + (points[3].X * points[2].Y) + (points[2].X * points[0].Y)) - ((points[0].X * points[2].Y) + (points[2].X * points[3].Y) + (points[3].X * points[0].Y));
        }

        public override void GetDiagonalsLength(out double d1, out double d2)
        {
            d1 = GetDistanceBetweenPoints(points[0], points[2]);
            d2 = GetDistanceBetweenPoints(points[1], points[3]);
        }
        public override double GetPerimeter()
        {
            return GetDistanceBetweenPoints(points[0], points[1]) * 2 + GetDistanceBetweenPoints(points[1], points[2]) * 2;
        }
        public override void GetAngles(out double angleA, out double angleB, out double angleC, out double angleD)
        {
            //находим угол А через стороны и диагональ, противолополжные углы равны, а сумма прилежащих = 180
            double a = GetDistanceBetweenPoints(points[0], points[1]),
                b = GetDistanceBetweenPoints(points[1], points[2]);
            angleB = (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(GetDistanceBetweenPoints(points[0], points[2]), 2)) / (2d * a * b);
            angleB = Math.Acos(angleB) * 180 / Math.PI;
            angleC = 180 - angleB;
            angleA = 180 - angleB;
            angleD = angleB;
        }
        public override void GetSides(out double a, out double b, out double c, out double d)
        {
            a = GetDistanceBetweenPoints(points[0], points[1]);
            b = GetDistanceBetweenPoints(points[1], points[2]);
            c = a;
            d = b;
        }
    }
}
