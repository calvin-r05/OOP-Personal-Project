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
                Movie m1 = new Movie(1, "Spider-Man: Far From Home", "John Watts", 2019, "https://th.bing.com/th/id/OIP.cOCZuI7fN77rAeIvXzsR3wHaLH?w=155&h=180&c=7&r=0&o=5&pid=1.7");
                Actor a1 = new Actor(1, "Tom Holland", 1, "Protagonist", m1, "https://th.bing.com/th/id/OIP.ktvpI9Jhc3WR3K_78MqBSwHaFj?w=205&h=180&c=7&r=0&o=5&pid=1.7");
                Actor a2 = new Actor(2, "Jake Gyllenhaal", 1, "Antagonist", m1, "https://th.bing.com/th/id/OIP.wKeaLg-Xcfv10sZIyRTDYQHaLG?w=186&h=279&c=7&r=0&o=5&pid=1.7");

                Movie m2 = new Movie(2, "Whiplash", "Damien Chazelle", 2014, "https://th.bing.com/th/id/OIP.lHjnrhHN-A1tY_91ql449gHaLH?w=156&h=180&c=7&r=0&o=5&pid=1.7");
                Actor a3 = new Actor(3, "Miles Teller", 2 , "Protagonist", m2 , "https://th.bing.com/th/id/OIP.e6rHpE7Lu8EJ1ePvE76JvgHaJd?w=186&h=237&c=7&r=0&o=5&pid=1.7");
                Actor a4 = new Actor(4, "J.K Simmons", 2 , "Antagonist", m2 , "https://th.bing.com/th/id/OIP.DfUf1fOZEKBuiw2pSXl10QHaLH?w=156&h=180&c=7&r=0&o=5&pid=1.7");

                Movie m3 = new Movie(3, "El Camino", "Vince Gilligan", 2019, "https://th.bing.com/th/id/OIP.s3IKs79zB1p1yjOys1S6jAHaJQ?w=156&h=180&c=7&r=0&o=5&pid=1.7");
                Actor a5 = new Actor(5, "Aaron Paul", 3, "Protagonist", m3, "https://th.bing.com/th/id/OIP.55Cx0Af9FhA6J6eVQ6iTjAHaJQ?w=186&h=233&c=7&r=0&o=5&pid=1.7");
                Actor a6 = new Actor(6, "Jesse Plemons", 3, "Antagonist", m3, "https://th.bing.com/th/id/OIP.38dgE60xZ3ddv-70aDa0jgHaKv?w=186&h=270&c=7&r=0&o=5&pid=1.7");

                Movie m4 = new Movie(4, "The Goonies", "Richard Donner", 1985, "https://th.bing.com/th/id/OIP.2JJArJ6wUDenugLyCSb_yQHaLH?w=156&h=180&c=7&r=0&o=5&pid=1.7");
                Actor a7 = new Actor(7, "Sean Astin", 4, "Protagonist", m4, "https://th.bing.com/th/id/OIP.yCJOKzVqQL-d--9x22x8twHaK4?w=186&h=273&c=7&r=0&o=5&pid=1.7");
                Actor a8 = new Actor(8, "Anne Ramsey", 4, "Antagonist", m4, "https://th.bing.com/th/id/OIP.z5C7ebnOGzyooaXro_TaLAHaD4?w=296&h=180&c=7&r=0&o=5&pid=1.7");

                Movie m5 = new Movie(5, "The Godfather", "Francis Coppola", 1972, "https://th.bing.com/th/id/OIP.3C9P6X2vrW-EGjNpsSMgyQHaK9?w=157&h=200&c=7&r=0&o=5&pid=1.7");
                Actor a9 = new Actor(9, "Marlon Brando", 5, "Protagonist", m5, "https://th.bing.com/th/id/OIP.3Mbe7YEL52Sjmwl2WOnClgHaJa?w=156&h=180&c=7&r=0&o=5&pid=1.7");
                Actor a10 = new Actor(10, "Richard Conte", 5, "Antagonist", m5, "https://th.bing.com/th/id/OSK.5PdH-VJ6OWnX4EoA5VIPCfO1R8WDwKG7y0M6MEqlFuE?w=224&h=200&c=12&rs=1&o=6&pid=SANGAM");

                Movie m6 = new Movie(6, "The Hunger Games", "Gary Ross", 2012, "https://th.bing.com/th/id/OIP._Sr2M9I5mRO2k1BWNz74VAHaJ4?rs=1&pid=ImgDetMain");
                Actor a11 = new Actor(11, "Jennifer Lawrence", 11, "Protagonist", m6, "https://th.bing.com/th/id/OIP.8ekOM2MZia28Z7P4ic_8RQHaNK?w=186&h=331&c=7&r=0&o=5&pid=1.7");
                Actor a12 = new Actor(12, "Donald Sutherland", 6, "Antagonist", m6, "https://th.bing.com/th/id/OIP.mOFrX7NuUdj4wmQjxxTjLwHaKB?w=186&h=252&c=7&r=0&o=5&pid=1.7");




                db.Movies.Add(m1); 
                db.Movies.Add(m2);
                db.Movies.Add(m3);
                db.Movies.Add(m4);
                db.Movies.Add(m5);
                db.Movies.Add(m6);
                Console.WriteLine("Added movies to database!");
                db.Actors.Add(a1);
                db.Actors.Add(a2);
                db.Actors.Add(a3);
                db.Actors.Add(a4);
                db.Actors.Add(a5);
                db.Actors.Add(a6);
                db.Actors.Add(a7);
                db.Actors.Add(a8);
                db.Actors.Add(a9);
                db.Actors.Add(a10);
                db.Actors.Add(a11);
                db.Actors.Add(a12);
                Console.WriteLine("Added actors to database!");
                db.SaveChanges();
                Console.WriteLine("Saved to database!");




            }
        }
    }
}
