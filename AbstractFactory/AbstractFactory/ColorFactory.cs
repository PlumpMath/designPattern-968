using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ColorFactory: AbstractFactory
    {
        public override IColor GetColor(string ColorName)
        {
            switch (ColorName)
            {
                case "Red":
                    return new Red();
                case "Blue":
                    return new Blue();
                default :
                    throw new ApplicationException(string.Format("Can not create the object for",ColorName));
            }
        }
        public override IShape GetShape(shape shape)
        {
            //throw new NotImplementedException();
            return null;
        }
    }
}
