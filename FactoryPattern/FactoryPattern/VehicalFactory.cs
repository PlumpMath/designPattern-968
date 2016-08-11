using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// this is abstract creator class
    /// it provides the template to concrete creator class
    /// </summary>
    abstract class VehicalFactory
    {
        public abstract IVehical GetVehical(string vehical);
    }
}
