using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonPattern
{
    class cSingleTon
    {
        private static cSingleTon DefInstance = null;
        private static int count { set; get; }

         private cSingleTon()
        {
             
        }

        public static cSingleTon GetInstance()
         {
             if (DefInstance==null)
             {
                 DefInstance = new cSingleTon();
             }
             return DefInstance;
         }
        public void sayHello()
        {
           Console.WriteLine("hello")
        }
    }
}
