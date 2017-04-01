using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LineSegments
{
    public class LineSegment
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public LineSegment(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
            Vector = new Vector2(X1, Y1, X2, Y2);
        }

        public Vector2 Vector { get; private set; }
    }

    public class Vector2
    {
        public Vector2(double x1, double y1, double x2, double y2)
        {
            X = x2 - x1;
            Y = y2 - y1;
        }

        public double X { get; private set; }
        public double Y { get; private set; }

        public static double CrossProduct(Vector2 Vector1, Vector2 Vector2)
        {
            //not a real cross product, i know, but it's a more cost friendly way to get if
            //it's a zero vector
            return ((Vector1.X * Vector2.Y) - (Vector1.Y * Vector2.X));
        }
    }
}
