using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [Controller]
    public class BookController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly BookManager _bookManager;
        public BookController(IConfiguration configuration)
        {
            _configuration = configuration;
            _bookManager = new BookManager(configuration);
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public async Task<ActionResult<List<Book>>> GetBooks() { 
            var books = await _bookManager.GetBooks();
            return Ok(books);
        }
    }
}
