using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1;

namespace Database_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieData db = new MovieData();

            using (db)
            {
                Movie m1 = new Movie(1, "Spider-Man: Far From Home", "John Watts", 2019);
                Actor a1 = new Actor(1, "Tom Holland", 1, "Protagonist", m1);
                Actor a2 = new Actor(2, "Jake Gyllenhaal", 1, "Antagonist", m1);

                Movie m2 = new Movie(2, "Whiplash", "Damien Chazelle", 2014);
                Actor a3 = new Actor(3, "Miles Teller", 2 , "Protagonist", m2 );
                Actor a4 = new Actor(4, "J.K Simmons", 2 , "Antagonist", m2 );


                
               
            }
        }
    }
}
