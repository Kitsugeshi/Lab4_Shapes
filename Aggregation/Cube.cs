using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal class Cube : IShape
    {
        public string Name => nameof(Cube);

        public Square A { get; }
        public Cube(Square a)
        {
            A = a;
        }
        public double GetSize()
        {
            return A.GetSize() * 6;
        }
    }
}
