using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    internal interface IShape
    {
        string Name { get; }
        double GetSize();
    }
}
