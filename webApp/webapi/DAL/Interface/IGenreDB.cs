using webapi.Models;

namespace webapi.DAL.Interface
{
    public interface IGenreDB
    {
        public Task<List<Genre>> GetGenres();
        public Task<Genre> CreateGenre(Genre genre);
        public Task<bool> DeleteGenre(Guid id);
    }
}
