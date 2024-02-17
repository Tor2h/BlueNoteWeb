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
                    .Include(b => b.BookTropes)
                    .ToListAsync();
                foreach (var book in books)
                {
                    foreach (var bg in book.BookGenres)
                    {
                        bg.Genre = await db.Genres.FirstOrDefaultAsync(g => g.ID.Equals(bg.GenreID));
                    }
                    foreach (var bt in book.BookTropes)
                    {
                        bt.Trope = await db.Tropes.FirstOrDefaultAsync(t => t.ID.Equals(bt.TropeID));
                    }
                }
            }
            return books;
        }
        public async Task<bool> CreateBook(Book book)
        {
            int result = 0;
            using (var db = new DatabaseContext(_configuration))
            {
                await db.Books.AddAsync(book);
                foreach (var bg in book.BookGenres)
                {
                    await db.BookGenres.AddAsync(bg);
                }
                foreach (var bt in book.BookTropes)
                {
                    await db.BookTropes.AddAsync(bt);
                }
                result = await db.SaveChangesAsync();
            }
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
