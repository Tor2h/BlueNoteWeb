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
                        TropeDTO trope = new TropeDTO { ID = bt.TropeID.ToString(), Name = bt.Trope.Name};
                        bookDTO.Tropes.Add(trope);
                    }
                }
                foreach (BookGenre bg in book.BookGenres)
                {
                    if (bg.Genre != null)
                    {
                        GenreDTO genre = new GenreDTO { ID = bg.GenreID.ToString(), Name = bg.Genre.Name };
                        bookDTO.Genres.Add(genre);
                    }
                }
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public async Task<bool> CreateBook(BookDTO bookDTO)
        {
            Book book = new Book {
                ID = Guid.NewGuid(),
                AaName = bookDTO.AaName,
                Author = bookDTO.Author,
                Series = bookDTO.Series,
                Comment = bookDTO.Comment
            };

            if (bookDTO.OwnedOrWish != null)
            {
                book.OwnedOrWish = (bool)bookDTO.OwnedOrWish;
            }
            if (bookDTO.Status != null)
            {
                book.Status = (Status)bookDTO.Status;
            }
            if (bookDTO.Score != null)
            {
                book.Score = (Score)bookDTO.Score;
            }
            if (bookDTO.Genres.Count > 0)
            {
                foreach (GenreDTO genreDTO in bookDTO.Genres)
                {
                    Genre genre = new Genre { ID = Guid.Parse(genreDTO.ID), Name = genreDTO.Name };
                    BookGenre bg = new BookGenre
                    {
                        Book = book,
                        BookID = book.ID,
                        ID = Guid.NewGuid(),
                        Genre = genre,
                        GenreID = genre.ID,
                    };
                    book.BookGenres.Add(bg);
                }
            }
            if (bookDTO.Tropes.Count > 0)
            {
                foreach (TropeDTO tropeDTO in bookDTO.Tropes)
                {
                    Trope trope = new Trope { ID = Guid.Parse(tropeDTO.ID), Name = tropeDTO.Name };
                    BookTrope bt = new BookTrope
                    {
                        Book = book,
                        BookID = book.ID,
                        ID = Guid.NewGuid(),
                        Trope = trope,
                        TropeID = trope.ID,
                    };
                    book.BookTropes.Add(bt);
                }
            }
            
            return await _bookDB.CreateBook(book);
        }
    }
}
