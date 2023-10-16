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
        public async Task<Genre> CreateGenre(string genreName)
        {
            Genre genre = new Genre() { ID = Guid.NewGuid(), Name = genreName };
            using (var db = new DatabaseContext(_configuration))
            {
                db.Genres.Add(genre);
            }
            return genre;
        }
    }
}
