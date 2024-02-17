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
        public async Task<bool> CreateBook(Book book)
        {
            int result = 0;
            using (var db = new DatabaseContext(_configuration))
            {
                await db.Books.AddAsync(book);
                
                result = await db.SaveChangesAsync();

            }
            using (var db = new DatabaseContext(_configuration))
            {
                foreach (BookGenre bookGenre in book.BookGenres)
                {
                    db.BookGenres.Add(bookGenre);
                }
                foreach (BookTrope bookTrope in book.BookTropes)
                {
                    db.BookTropes.Add(bookTrope);
                }
                _ = await db.SaveChangesAsync();
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
