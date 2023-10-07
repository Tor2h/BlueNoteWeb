using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [Controller]
    public class GenreController
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
    }
}
