using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    public class BookController
    {
        private readonly ILogger<BookController> _logger;
        private readonly IConfiguration _configuration;
        private readonly BookManager _bookManager;

        public BookController(ILogger<BookController> logger, IConfiguration configuration, BookManager bookManager)
        {
            _logger = logger;
            _configuration = configuration;
            _bookManager = bookManager;
        }

        [HttpGet]
        public async IEnumerable<Book> GetBooks()
        {
            
            return await _
        }
    }
}
