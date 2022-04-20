using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCoreApp.BAL.services;
using MovieCoreApp.Entity.Models;
using System.Collections.Generic;

namespace MovieCoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MovieService _movieService;
        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet("GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _movieService.GetMovies();
        }


        [HttpPost("AddMovie")]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _movieService.AddMoive(movie);
            return Ok("Movie created successfully!!");
        }
        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int movieId)
        {
            _movieService.DeleteMovie(movieId);
            return Ok("Movie deleted successfully!!");
        }
        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] Movie movie)
        {
            _movieService.UpdateMoive(movie);
            return Ok("Movie updated successfully!!");
        }
    }
}
