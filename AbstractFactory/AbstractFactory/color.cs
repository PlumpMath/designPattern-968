using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Blue:IColor
    {
        public void Fill(string colorName)
        {
            Console.WriteLine("Blue color Filled");
        }
    }
    class Red : IColor
    {
        public void Fill(string colorName)
        {
            Console.WriteLine("Red color Filled");
        }
    }

}
