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
        public string Images { get; set; }
        public virtual List<Actor> Actors { get; set; }
       

        public Movie() { }

        public Movie(int id, string name, string director, int yearReleased)
        {
            MovieID = id;
            MovieName = name;
            Director = director;
            YearReleased = yearReleased;
        }

        public override string ToString()
        {
            return $"{MovieName} ({YearReleased})";
        }
    }

    public class Favorite
    {
        int ID = 0;
        public int FavoriteID { get; set; }
        public Movie Movie { get; set; }

        public Favorite() { }
        public Favorite(Movie movie)
        {
            ID++;
            FavoriteID = ID;
            Movie = movie;
        }
        public override string ToString()
        {
            return $"{Movie.MovieName}";
        }
    }
    public class MovieData : DbContext
    {
        public MovieData() : base("MovieData") { }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
    }
}
