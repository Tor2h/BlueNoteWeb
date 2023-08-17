using Microsoft.AspNetCore.Mvc;
using webapi.BLL;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    public class BookController
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        public BookController(ILogger logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            BookManager _bookManager = new BookManager(_logger, _configuration);
            List<Book> books = await _bookManager.GetBooks();
            return books;
        }
    }
}
