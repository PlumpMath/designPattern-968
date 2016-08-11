using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ConcreteCreator:VehicalFactory
    {
        public override IVehical GetVehical(string vehical)
        {
            switch(vehical)
            {
                case "scooter":
                    return new Scooter();
                case "car":
                    return new Car();
                default : throw new ApplicationException(string.Format("vehical {0} can not be created",vehical));
            }
        }
    }
}
