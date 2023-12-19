using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cube : Square
    {
        public override string Name => nameof(Cube);
        public Cube(double x1, double y1, double x2, double y2) : base(x1, y1, x2, y2)
        {

        }

        public override double GetSize()
        {
            return base.GetSize() * 6;
        }
    }
}
