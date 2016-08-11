using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
    class Circle:IShape
    {
        
        public void Draw(int radius)
        {
            Console.WriteLine("cricle is drawn with  radius {0}",radius);
        }
    }

    class Square : IShape
    {
        public void Draw(int side)
        {
            Console.WriteLine("square is drawn wiht side {0}", side);
        }
    }
}
