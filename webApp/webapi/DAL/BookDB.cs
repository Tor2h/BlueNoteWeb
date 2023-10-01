using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using webapi.BLL;
using webapi.DAL.Interface;
using webapi.Models;

namespace webapi.DAL
{
    public class BookDB : IBookDB
    {
        private readonly IConfiguration _configuration;
        public BookDB(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        
        public async Task<List<Book>> GetBooks()
        {
            List<Book> books = new();
            using (var db = new DatabaseContext(_configuration))
            {
                books = await db.Books
                    .Include(b => b.BookGenres)
                    .ThenInclude(bg => bg.Genre)
                    .Include(b => b.BookTropes)
                    .ThenInclude(b => b.Trope)
                    .ToListAsync();
            }
            return books;
        }

    }
}
