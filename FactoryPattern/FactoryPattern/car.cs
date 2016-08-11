using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// concrete product 2
    /// </summary>
    class Car:IVehical
    {
        public void drive(int distance)
        {
            Console.WriteLine("Car can drtive {0} kms", distance);
        }

        public int GetNumberOfWheel()
        {
            return 4;
        }
    }
}
