using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Square : LineSegment
    {
        public override string Name => nameof(Square);
        public Square(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {

        }

        public override double GetSize()
        {
            return Math.Pow(base.GetSize(), 2);
        }

    }
}
