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
        public async Task<List<BookDTO>> GetBooks()
        {
            List<Book> books = await _bookDB.GetBooks();

            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books) 
            {
                BookDTO bookDTO = new BookDTO{
                    ID = book.ID,
                    AaName = book.AaName,
                    Author = book.Author,
                    Series = book.Series,
                    OwnedOrWish = book.OwnedOrWish,
                    Status = book.Status,
                    Score = book.Score,
                    Comment = book.Comment
                };
                foreach (BookTrope bt in book.BookTropes)
                {
                    if (bt.Trope != null) 
                    { 
                        bookDTO.Tropes.Add(bt.Trope);
                    }
                }
                foreach (BookGenre bg in book.BookGenres)
                {
                    if (bg.Genre != null)
                    {
                        bookDTO.Genres.Add(bg.Genre);
                    }
                }
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }
    }
}
