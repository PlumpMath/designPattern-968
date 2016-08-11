using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //cSingleTon obj = new cSingleTon();
            cSingleTon obj = cSingleTon.GetInstance();
            obj.count = 10;
            obj.sayHello();
            Console.ReadKey();
            cSingleTon obj1 = cSingleTon.GetInstance();
            Console.WriteLine("count={0}", obj1.count);
            Console.ReadKey();
        }
    }
}
