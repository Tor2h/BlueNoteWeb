using webapi.Models;

namespace webapi.DAL.Interface
{
    public interface IBookDB
    {
        Task<bool> CreateBook(Book book);
        public Task<List<Book>> GetBooks();
    }
}
