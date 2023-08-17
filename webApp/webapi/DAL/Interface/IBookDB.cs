using webapi.Models;

namespace webapi.DAL.Interface
{
    public interface IBookDB
    {
        public Task<List<Book>> GetBooks();
    }
}
