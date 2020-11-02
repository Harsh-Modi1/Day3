using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3practice
{
    class Day3Practice
    {
        int courseid, fees;
        string coursename;
        internal static string institution;
        //Create a constructor
        internal Day3Practice(int courseid, int fees, string coursename)
        {
            this.courseid = courseid;
            this.fees = fees;
            this.coursename = coursename;

        }

        internal void Display()
        {
            Console.WriteLine("CourseID : {0} || Fees : {1} || Coursename :{2} ||Institution: {3}", courseid, fees, coursename,institution);

        }
        static int collegeid = 222;
        internal static int DisplayCollegeid()
        {
            return collegeid;
        }
    }
    class CourseDetails
    {
        static void Main()
        {

            Console.WriteLine("Enter the COllegeName :");
            Day3Practice.institution = Console.ReadLine();

            int num;
            Console.WriteLine("provide number of input");
            num = Convert.ToInt32(Console.ReadLine());

            Day3Practice[] practice = new Day3Practice[num];
          
            int courseid;
            int fees;
            string coursename;
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("Enter CourseID : ");
                courseid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Fees:");
                fees = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course name :");
                coursename = Console.ReadLine();

                practice[i]= new Day3Practice(courseid, fees,coursename);
            }

            for (int i = 0; i < num; i++)
            {
                practice[i].Display();

            }
            Console.WriteLine("College id :{0}", Day3Practice.DisplayCollegeid());


            Console.Read();
        }
    }
       

 }



