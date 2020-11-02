using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Mobile
    {
       internal static string companyname; // class variable
      internal  string Modelname;   //object variable
        
        //non static method can access both static and non static information
        void DisplayModel()
        {
            Console.WriteLine("Company name :{0} || Model name : {1}", companyname, Modelname);
        }

        //static method can access only static variables cannot access the non static variable
        internal static void Getdata()
        {
            int isbn = 1900;
            Console.WriteLine("Company name :{0} || Model name : {1}", companyname/*, Modelname*/);
        }
    }
    class StaticEg2
    {
        float f = 34.90f;

        internal static void Info()
        {
            Console.WriteLine("Static Method");
        }
        static void Main()
        {
            //error: trying to access non static member inside static function
            //f=f+f;
            int age, pincode;

            Mobile mobile = new Mobile();
            mobile.Modelname = "moto g4 plus";

            Mobile.companyname = "Motorola";
            Mobile.Getdata();

            //Info method and static method in same class, then class name is not required
            Info();

            Console.Read();


           
        }
        

        



    }
}
