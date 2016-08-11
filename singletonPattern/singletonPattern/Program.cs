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
            obj.sayHello();
            Console.ReadKey();
        }
    }
}
