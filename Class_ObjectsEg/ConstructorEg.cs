using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Pen
    {
         int ISBN;
          string brand;
         string color;
        //Constructor--special method , by default it is private
        //constructor name should be same that of your class name
        //Constructor do not have written type
        //Initialize the value for the variables


            //concept of Constructor Overloading
        internal Pen()// no arguements so default constructor
        {
            Console.WriteLine("Default Constructor");
        }

        internal Pen(int ISBN)//1 Arguements
        {
            this.ISBN = ISBN;
            Console.WriteLine(ISBN);
        }
       internal Pen(string b,string color)//2 Arguements
        {
            brand = b;
            //refers to current class instance-->Pen
            this.color = color;

        }
        internal void DisplayPen()
        {
            Console.WriteLine("Brand:{0}||Color:{1}", brand, color);
        }
    }
    class ConstructorEg
    {
        static void Main()
        {
            Pen p = new Pen();//call constructor with no arguements
            Pen p1 = new Pen(12345);//call constructor with one arguements
            Pen pen = new Pen("Parker","blue");//call constructor with two arguements
            //constructor
            /*  pen.brand = "Parker";
              pen.color = "blue";*/

            pen.DisplayPen();

            Console.Read();
        }
        
    }
}
