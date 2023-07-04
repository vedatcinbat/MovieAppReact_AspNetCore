using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using MovieAppApi.Models;
using MovieAppApi.Data;


namespace MovieAppApi.Controllers{
    
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase {

        public MoviesRepositoryContext _context;
        public MoviesController(MoviesRepositoryContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult Movies() {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }
        [HttpGet("{id}")]
        public IActionResult MoviesWithId([FromRoute(Name = "id")]int id) {
            var movie = _context.Movies.Where(movie => movie.MovieId.Equals(id));
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult PostMovie(Movie movie) {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id) {
            var movie = _context.Movies.Where(movie => movie.MovieId.Equals(id)).SingleOrDefault();
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Ok(movie);
        }
        
        
    } 
}


