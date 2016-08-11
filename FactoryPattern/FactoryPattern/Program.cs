using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicalFactory vehicalFactory = new ConcreteCreator();
            IVehical scooter = vehicalFactory.GetVehical("scooter");
            scooter.drive(10);
            Console.WriteLine("scooter has {0} wheel", scooter.GetNumberOfWheel());
            IVehical car = vehicalFactory.GetVehical("car");
            car.drive(25);
            Console.WriteLine("car has {0} wheel", car.GetNumberOfWheel());
            Console.ReadKey();
        }
    }
}
