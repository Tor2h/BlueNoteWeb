using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
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
            return Ok(genres);
        }

        [HttpPost]
        [Route("/genres")]
        public async Task<ActionResult<Genre>> CreateGenre(Genre genre)
        {
            var result = await _genreManager.CreateGenre(genre);
            return Ok(result);
        }

        [HttpDelete]
        [Route("/genres")]
        public async Task<ActionResult<bool>> DeleteGenre(Guid id)
        {
            var result = await _genreManager.DeleteGenre(id);
            return Ok(result);
        }
    }
}
