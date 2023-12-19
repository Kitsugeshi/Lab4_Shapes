using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class LineSegment : IShape
    {
        public string Name => nameof(LineSegment);
        public Point A { get; }
        public Point B { get; }

        public LineSegment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public double GetSize()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2)));
        }
    }
}
