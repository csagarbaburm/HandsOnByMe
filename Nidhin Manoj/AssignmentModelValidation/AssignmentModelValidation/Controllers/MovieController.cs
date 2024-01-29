using AssignmentModelValidation.Model;
using AssignmentModelValidation.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentModelValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
       private readonly IMovieRepository movieRepository;

        public MovieController()
        {
            movieRepository = new MovieRepository();
       }
        [HttpPost, Route("AddMovie")]
        public IActionResult Add(Movie movie)
        {
            try
            {
                movieRepository.AddMovie(movie);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {
                List<Movie> movies = movieRepository.GetAllMovies();
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetMovieByName/{name}")]
        public IActionResult GetMovieByName(string name)
        {
            try
            {

                Movie movie = movieRepository.GetMovieByName(name);
                return StatusCode(200, movie);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetMovieByActor/{actor}")]
        public IActionResult GetMoviesByActor(string actor)
        {
            try
            {

                List<Movie> movies = movieRepository.GetMoviesByActor(actor);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetMoviesByReleaseYear/{year}")]
        public IActionResult GetMoviesByYear(int year)
        {
            try
            {

                List<Movie> movies = movieRepository.GetMoviesByReleaseYear(year);
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetMoviesByDirector/{director}")]
        public IActionResult GetMoviesByDirector(string director)
        {
            try
            {

                List<Movie> movies = movieRepository.GetMoviesByDirector(director
                    );
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
