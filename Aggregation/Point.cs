using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class Point : IShape
    {
        public string Name => nameof(Point);
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double GetSize()
        {
            return 0;
        }
    }
}
