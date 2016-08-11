using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    enum shape 
    {
        Circle, Square
    }
    class shapeFactory:AbstractFactory
    {
         public override IShape GetShape(shape shape)
        {
           switch(shape)
           {
               case shape.Circle:
                   return new Circle();
               case shape.Square:
                   return new Square();
               default : 
                   throw new ApplicationException (string.Format("can not create the object for {0} type",shape));
           }
        }
         public override IColor GetColor(string colorName)
         {
             //throw new NotImplementedException();
             return null;
         }
    }
}
