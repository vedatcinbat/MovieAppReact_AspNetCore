using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using MovieAppApi.Models;
using MovieAppApi.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieAppApi.Controllers{
    
    [ApiController]
    [Route("api/filteryear")]
    public class MovieAppApi : ControllerBase {

        public MoviesRepositoryContext _context;
        public MovieAppApi(MoviesRepositoryContext context) {
            _context = context;
        }

        [HttpGet("{year}")]
        public IActionResult FilterYear(int year) {
            var items = _context.Movies.Where(movie => movie.MovieYear > year);
            return Ok(items);
        }
        
        
        
    } 
}


