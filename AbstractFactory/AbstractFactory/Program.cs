using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProducer Fproducer = new FactoryProducer();
            AbstractFactory shapeFactory = Fproducer.GetFactory("Shape");
            IShape Circle = shapeFactory.GetShape(shape.Circle);
            Circle.Draw(10);
            IShape Square = shapeFactory.GetShape(shape.Square);
            Square.Draw(20);

            IColor temp = shapeFactory.GetColor("");

            AbstractFactory colorFactory =  Fproducer.GetFactory("Color");
            IColor Red = colorFactory.GetColor("Red");
            IColor Blue = colorFactory.GetColor("Blue");
            Red.Fill("");
            Blue.Fill("");
            Console.ReadKey();
        }
    }
}
