﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Student
    {
        internal static string collegename;
        string name;
        string dept;

        internal Student(string name,string dept)
        {
            this.name = name;
            this.dept = dept;
        }
        internal void DisplayDetails()
        {
            Console.WriteLine("Name :{0} || Department : {1} || Collegename:{2}", name, dept,collegename);
        }
    }
    class StaticEg
    {
        static void Main()
        {
            //accessing static variable by class name

            Console.WriteLine("Enter the COllegeName :");
            Student.collegename = Console.ReadLine();

            string name, dept;

            Console.WriteLine("Enter the no of Student:");
            int no = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[no];

            for(int i=0;i<student.Length;i++)
            {
                Console.WriteLine("Enter the Student Name :");
                name = Console.ReadLine();
                Console.WriteLine("Enter the dept name :");
                dept = Console.ReadLine();
                student[i] = new Student(name, dept);

            }
            for (int i=0;i<no;i++)
            {
                student[i].DisplayDetails
            }

        }
        



    }
}
