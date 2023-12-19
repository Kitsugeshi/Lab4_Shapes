using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class Square : IShape
    {
        public string Name => nameof(Square);
        public LineSegment A { get; }
        public Square(LineSegment a)
        {
            A = a;
        }

        public double GetSize()
        {
            return Math.Pow(A.GetSize(), 2);
        }
    }
}
