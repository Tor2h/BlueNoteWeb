using webapi.Models;

namespace webapi.BLL
{
    public class BookManager
    {
        private readonly ILogger<BookManager> _logger;
        private readonly IConfiguration _configuration;
        public BookManager(ILogger<BookManager> logger, IConfiguration configuration)
        {
            this._logger = logger;
            this._configuration = configuration;
        }
        public List<Book> GetBooks()
        {
            List<Book> result = 
        }
    }
}
