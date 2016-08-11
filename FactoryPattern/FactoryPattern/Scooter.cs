using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// concrete product 1
    /// </summary>
    class Scooter :IVehical
    {
        public void drive(int distance)
        {
            Console.WriteLine("scooter can drive {0} kms", distance);
        }
        public int GetNumberOfWheel()
        {
            return 2;
        }
    }
}
