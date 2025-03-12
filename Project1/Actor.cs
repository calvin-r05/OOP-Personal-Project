using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Actor
    {
        public int ActorID { get; set; }
        public string Name { get; set; }
        public int MovieID { get; set; }
        public string Role { get; set; }
        public string Images { get; set; }
        public virtual Movie Movie { get; set; }

        public Actor() { }

        public Actor(int id,  string name, int movieID, string role, Movie movie)
        {
            ActorID = id;
            Name = name;
            MovieID = movieID;
            Role = role;
            Movie = movie;
        }

        public override string ToString()
        {
            return $"{Name} ({Role})";
        }


    }
}
