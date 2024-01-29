using AssignmentModelValidation.Model;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace AssignmentModelValidation.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>();
   
        public void AddMovie(Movie movie)
        {
          movies.Add(movie);
        }

        public List<Movie> GetAllMovies()
        {
           return movies;
        }

        public Movie GetMovieByName(string MovieName)
        {
            try
            {
                var movie = new Movie();
                foreach (var m in movies)
                {
                    if (m.MovieName == MovieName)
                    {
                        movie = m;
                        break;
                    }
                }
                return movie;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Movie> GetMoviesByActor(string Actor)
        {
            try
            {
                var movieslist = new List <Movie>();
                foreach (var m in movies)
                {
                    if (m.Actor == Actor)
                    {
                        movieslist.Add(m);
                        
                    }
                }
                return movieslist;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<Movie> GetMoviesByDirector(string Director)
        {
            try
            {
                var movieslist = new List<Movie>();
                foreach (var m in movies)
                {
                    if (m.Director == Director)
                    {
                        movieslist.Add(m);

                    }
                }
                return movieslist;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<Movie> GetMoviesByReleaseYear(int ReleaseYear)
        {
            try
            {
                var movieslist = new List<Movie>();
                foreach (var m in movies)
                {
                    if (m.ReleaseYear == ReleaseYear)
                    {
                        movieslist.Add(m);

                    }
                }
                return movieslist;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
