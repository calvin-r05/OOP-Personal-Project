using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Project1;

namespace Project1
{
    /// <summary>
    /// Interaction logic for Movie_Details.xaml
    /// </summary>
    public partial class Movie_Details: Window
    {
        MovieData db = new MovieData();
        public Movie_Details(Movie selectedMovie)
        {
            InitializeComponent();
            if (selectedMovie != null)
            {
                imgMovie.Source = new BitmapImage(new Uri(selectedMovie.Images));
                var actors = from a in db.Actors
                             where a.MovieID == selectedMovie.MovieID
                             select a;

                foreach (var actor in actors)
                {
                    if (actor.Role == "Protagonist")
                    {
                        ImgLead.Source = new BitmapImage(new Uri(actor.Images));
                        tblxLead.Text = actor.Name;
                    }
                    else if (actor.Role == "Antagonist")
                    {
                        imgAnt.Source = new BitmapImage(new Uri(actor.Images));
                        tblxAnt.Text = actor.Name;
                    }
                }
                tblxDirector.Text = selectedMovie.Director;
                tblxReleased.Text = selectedMovie.YearReleased.ToString();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
