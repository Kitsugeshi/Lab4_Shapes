using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class LineSegment : Point
    {
        public override string Name => nameof(LineSegment);
        public double X2 { get; }
        public double Y2 { get; }
        public LineSegment(double x1, double y1, double x2, double y2) : base(x1, y1)
        {
            X2 = x2;
            Y2 = y2;
        }

        public override double GetSize()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(X - X2, 2) + Math.Pow(Y - Y2, 2)));
        }
    }
}
