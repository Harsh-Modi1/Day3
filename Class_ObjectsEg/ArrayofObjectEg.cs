using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ObjectsEg
{
    class Movie
    {
        int id;
        string moviename;
        DateTime year;

        internal Movie(int id,string moviename,DateTime year)
        {
            this.id = id;
            this.moviename = moviename;
            this.year = year;
        }

        internal void DisplayMovie()
        {
            Console.WriteLine("Id : {0} || Moviename : {1} || Year : {2}", id, moviename, year);
        }

    }
    class ArrayofObjectEg
    {
        static void Main()
        {
            Movie movie = new Movie(101, "Dangal", Convert.ToDateTime("2017-07-16"));
            movie.DisplayMovie();
            //applying array to objects to fetch multiple movie info
            //array of object
            //datatype[]arrayname=new datatype[size];

            //statically
            /* Movie[] mov = new Movie[2];
             mov[0] = new Movie(102, "Raazi", Convert.ToDateTime("2017-05-16"));
             mov[1] = new Movie(103, "Boss", Convert.ToDateTime("2017-03-16"));*/

            /*   for (int i=0;i<2;i++)
               {

               }

               for(int i=0;i<2;i++)
               {
                   mov[i].DisplayMovie();
               }*/

            int num;
            Console.WriteLine("provide number of input");
            num = Convert.ToInt32(Console.ReadLine());

            Movie[] mov = new Movie[num];
            int id;
            DateTime year;
        
            string moviename;
            for (int i = 0; i < num; i++)
            {

                Console.WriteLine("provide movie id");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("provide movie name");
                moviename = Console.ReadLine();
                Console.WriteLine("provide movie year");
                year = Convert.ToDateTime(Console.ReadLine());

                mov[i] = new Movie(id, moviename,year);
            }

            for (int i = 0; i < num; i++)
            {
                mov[i].DisplayMovie();
            }
            

            Console.Read();
        }
    }
}
