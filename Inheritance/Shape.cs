using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Shape
    {
        public virtual string Name => nameof(Shape);
        public virtual double GetSize()
        {
            return default;
        }
    }
}
