using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryProducer
    {
        internal AbstractFactory AbstractFactory
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public AbstractFactory GetFactory(string FactoryType)
        {
            switch (FactoryType)
            {
                case "Shape":
                    return new shapeFactory();
                case "Color":
                    return new ColorFactory();
                default: throw new ApplicationException("can not create factory");
            }
        }
    }
}
