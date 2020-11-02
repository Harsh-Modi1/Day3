using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Shape
    {
        internal double Area(int r)
        {
            return(3.14*r*r);
        }
        internal int Area(int a,int b)
        {
            return a * b;
        }
    }
    class MethodOverloadingEg
    {
        static void Main()
        {
            Shape shape = new Shape();
            Console.WriteLine("Area of Circle :{0}",shape.Area(4));
            Console.WriteLine("Area of rectangle :{0}", shape.Area(6, 7));

            Console.Read();
        }
    }
}
