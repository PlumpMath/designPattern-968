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
        public int count { set; get; }
        /// <summary>
        /// private, so that calss can not be instantiated
        /// </summary>
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
            Console.WriteLine("hello");
        }
    }
}
