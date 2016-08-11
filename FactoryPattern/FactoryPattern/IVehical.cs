using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// product interface
    /// </summary>
    interface IVehical
    {
        void drive(int distance);
        int GetNumberOfWheel();
    }
}
