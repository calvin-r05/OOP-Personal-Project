using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName {  get; set; }
        public string Director { get; set; }
        public int YearReleased { get; set; }
        public virtual List<Actor> Actors { get; set; }

        public Movie() { }

        public Movie(int id, string name, string director, int yearReleased)
        {
            MovieID = id;
            MovieName = name;
            Director = director;
            YearReleased = yearReleased;
        }
    }
    public class MovieData : DbContext
    {
        public MovieData() : base("MovieData") { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
