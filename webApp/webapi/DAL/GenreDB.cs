using Microsoft.EntityFrameworkCore;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.DAL
{
    public class GenreDB : IGenreDB
    {
        private readonly IConfiguration _configuration;
        public GenreDB(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<Genre>> GetGenres()
        {
            List<Genre> genres = new List<Genre>();
            using (var db = new DatabaseContext(_configuration))
            {
                genres = await db.Genres.ToListAsync();
            }
            return genres;
        }
        public async Task<Genre> CreateGenre(Genre genre)
        {
            genre.ID = Guid.NewGuid();
            using (var db = new DatabaseContext(_configuration))
            {
                db.Genres.Add(genre);
                _ = await db.SaveChangesAsync();
            }
            return genre;
        }
        public async Task<bool> DeleteGenre(Guid id)
        {
            bool result = false;
            using (var db = new DatabaseContext(_configuration))
            {
                var genre = await db.Genres.Where(g => g.ID == id).FirstOrDefaultAsync();
                if (genre != null)
                {
                    db.Genres.Remove(genre);
                    result = true;
                }
                _ = await db.SaveChangesAsync();
            }
            return result;
        }
    }
}
