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
        public BookController(IConfiguration configuration, BookManager bookManager)
        {
            _configuration = configuration;
            _bookManager = bookManager;
        }

        [HttpGet]
        [Route("api/[Controller]")]
        public async Task<ActionResult<List<Book>>> GetBooks() { 
            List<Book> books = await _bookManager.GetBooks();
            return Ok(books);
        }
    }
}
