using webapi.DAL;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.BLL
{
    public class BookManager
    {
        private readonly ILogger _logger;
        private readonly IConfiguration _configuration;
        private readonly IBookDB _bookDB;
        public BookManager(ILogger logger, IConfiguration configuration)
        {
            this._logger = logger;
            this._configuration = configuration;
            this._bookDB = new BookDB(_logger, _configuration);
        }
        public async Task<List<Book>> GetBooks()
        {
            List<Book> books = new List<Book>();
            //books = await _bookDB.GetBooks();
            return books;
        }
    }
}
