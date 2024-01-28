using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly BookManager _bookManager;
        public BookController(IConfiguration configuration)
        {
            _configuration = configuration;
            _bookManager = new BookManager(_configuration);
        }

        [HttpGet]
        [Route("/books")]
        public async Task<ActionResult<List<BookDTO>>> GetBooks() 
        { 
            var books = await _bookManager.GetBooks();
            return Ok(books);
        }

        [HttpPost]
        [Route("/books")]
        public async Task<ActionResult<BookDTO>> CreateBook(BookDTO book)
        {
            var result = await _bookManager.CreateBook(book);
            return Ok(result);
        }
    }
}
