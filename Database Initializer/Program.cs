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

                Movie m3 = new Movie(3, "El Camino", "Vince Gilligan", 2019);
                Actor a5 = new Actor(5, "Aaron Paul", 3, "Protagonist", m3);
                Actor a6 = new Actor(6, "Jesse Plemons", 3, "Antagonist", m3);

                Movie m4 = new Movie(3, "The Goonies", "Richard Donner", 1985);
                Actor a7 = new Actor(5, "Sean Astin", 4, "Protagonist", m4);
                Actor a8 = new Actor(6, "Anne Ramsey", 4, "Antagonist", m4);

                db.Movies.Add(m1);
                db.Movies.Add(m2);
                db.Movies.Add(m3);
                db.Movies.Add(m4);
                Console.WriteLine("Added movies to database!");
                db.Actors.Add(a1);
                db.Actors.Add(a2);
                db.Actors.Add(a3);
                db.Actors.Add(a4);
                db.Actors.Add(a5);
                db.Actors.Add(a6);
                db.Actors.Add(a7);
                db.Actors.Add(a8);
                Console.WriteLine("Added actors to database!");
                db.SaveChanges();
                Console.WriteLine("Saved to database!");




            }
        }
    }
}
