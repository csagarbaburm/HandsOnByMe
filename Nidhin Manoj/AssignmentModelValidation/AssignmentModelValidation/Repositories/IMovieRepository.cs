using AssignmentModelValidation.Model;

namespace AssignmentModelValidation.Repositories
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        List<Movie> GetAllMovies();
        Movie GetMovieByName(string MovieName);
        List<Movie> GetMoviesByActor(string Actor);

        List<Movie> GetMoviesByReleaseYear(int ReleaseYear);

        List<Movie> GetMoviesByDirector(string Director);
    }
}
