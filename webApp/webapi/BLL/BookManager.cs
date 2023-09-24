using webapi.DAL;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.BLL
{
    public class BookManager
    {
        private readonly IConfiguration _configuration;
        private readonly IBookDB _bookDB;
        public BookManager(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._bookDB = new BookDB(_configuration);
        }
        public async Task<List<Book>> GetBooks()
        {
            List<Book> books = new List<Book>();
            books = await _bookDB.GetBooks();
            return books;
        }
    }
}
