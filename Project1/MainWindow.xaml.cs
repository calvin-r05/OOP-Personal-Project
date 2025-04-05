using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MovieData db = new MovieData();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            var query = from m in db.Movies
                        orderby m.MovieName
                        select m;

            var query1 = from f in db.Favorites
                         orderby f.Movie.MovieName
                         select f;

            lbxMovies.ItemsSource = query.ToList();
            lbxMovies.SelectedItem = 0;
            lbxFavorites.ItemsSource = query1.ToList();
            lbxFavorites.SelectedItem = 0;
        }

        private void lbxMovies_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (lbxMovies.SelectedItem != null)
            {
                Movie selected = lbxMovies.SelectedItem as Movie;
                var query1 = from a in db.Actors
                             where a.MovieID == selected.MovieID
                             select a;
                lbxActors.ItemsSource = query1.ToList();
                lbxFavorites.SelectedItem = null;
            }

                         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool checker = false;
            if (lbxMovies.SelectedItem != null)
            {
                Movie selected = lbxMovies.SelectedItem as Movie;
                var query2 = from f in db.Favorites
                             select f.Movie.MovieID;
                foreach( var ID in query2.ToList())
                {
                    if (ID == selected.MovieID)
                    {
                        checker = true;
                        break;
                    }
                }
                if (checker == false)
                {
                    Favorite temp = new Favorite(selected);
                    db.Favorites.Add(temp);
                    db.SaveChanges();
                    var query = from f in db.Favorites
                                orderby f.Movie.MovieName
                                select f;
                    lbxFavorites.ItemsSource = query.ToList();
                }
            }
        }

        private void btnUnfav_Click(object sender, RoutedEventArgs e)
        {
            if (lbxFavorites.SelectedItem != null)
            {
                Favorite selected = lbxFavorites.SelectedItem as Favorite;
                var query1 = from f in db.Favorites
                             where f.Movie.MovieName == selected.Movie.MovieName
                             select f;
                foreach (var favorite in query1.ToList())
                {
                    db.Favorites.Remove(favorite);
                }
                db.SaveChanges();
                var query = from f in db.Favorites
                            select f;
                lbxFavorites.ItemsSource = query.ToList();
            }
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            if (lbxMovies.SelectedItem != null)
            {
                Movie_Details movieDetails = new Movie_Details(lbxMovies.SelectedItem as Movie);
                movieDetails.Show();
            }
            else if (lbxFavorites.SelectedItem != null)
            {
                Favorite selected = lbxFavorites.SelectedItem as Favorite;
                var query1 = (from f in db.Favorites
                             where f.Movie.MovieID == selected.Movie.MovieID
                             select f.Movie).Single();
                Movie_Details movieDetails = new Movie_Details(query1 as Movie);
                movieDetails.Show();
            }
        }

        private void lbxFavorites_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbxFavorites.SelectedItem != null)
            {
                Favorite selected = lbxFavorites.SelectedItem as Favorite;
                var query1 = from a in db.Actors
                             where a.MovieID == selected.Movie.MovieID
                             select a;

                var query2 = from m in db.Movies
                             where m.MovieID == selected.Movie.MovieID
                             select m; 
                lbxMovies.SelectedItem = null;
                lbxActors.ItemsSource = query1.ToList();
            }

        }

        private void tbxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResults = from m in db.Movies
                                where m.MovieName.Contains(tbxSearch.Text)
                                orderby m.MovieName
                                select m;
            lbxMovies.ItemsSource = searchResults.ToList();
        }

        private void tbxSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxSearch.Clear();
        }
    }
    
}
