using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractFactory
    {
        public abstract IShape GetShape(shape shape);
        public abstract IColor GetColor(string colorName);
    }
}
