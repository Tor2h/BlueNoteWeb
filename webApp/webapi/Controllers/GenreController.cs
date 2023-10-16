using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [Controller]
    public class GenreController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly GenreManager _genreManager;
        
        public GenreController(IConfiguration configuration)
        {
            _configuration = configuration;
            _genreManager = new GenreManager(_configuration);
        }
        [HttpGet]
        [Route("/genres")]
        public async Task<ActionResult<List<Genre>>> GetGenres()
        {
            var genres = await _genreManager.GetGenres();
            return genres;
        }

        [HttpPost]
        [Route("/genres")]
        public async Task<ActionResult<Genre>> CreateGenre(string genreName)
        {
            var genre = await _genreManager.CreateGenre(genreName);
            return Ok(genre);
        }
    }
}
