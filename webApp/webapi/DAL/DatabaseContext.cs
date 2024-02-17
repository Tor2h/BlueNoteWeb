using Microsoft.EntityFrameworkCore;
using webapi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace webapi.DAL
{
    public class DatabaseContext : DbContext
    {
        IConfiguration _configuration;
        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ConnectMsSqlString"));
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Trope> Tropes { get; set; }
        public DbSet<BookTrope> BookTropes { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Book>().HasKey(b => b.ID);
            modelBuilder.Entity<Book>().Property(b => b.ID);
            modelBuilder.Entity<Book>().Property(b => b.AaName);
            modelBuilder.Entity<Book>().Property(b => b.Author);
            modelBuilder.Entity<Book>().Property(b => b.Series);
            modelBuilder.Entity<Book>().Property(b => b.OwnedOrWish);
            modelBuilder.Entity<Book>().Property(b => b.Status);
            modelBuilder.Entity<Book>().Property(b => b.Score);
            modelBuilder.Entity<Book>().Property(b => b.Comment);
            modelBuilder.Entity<Book>().HasMany(b => b.BookGenres).WithOne(bg => bg.Book).HasForeignKey(bg => bg.BookID);
            modelBuilder.Entity<Book>().HasMany(b => b.BookTropes).WithOne(bt => bt.Book).HasForeignKey(bt => bt.BookID);

            modelBuilder.Entity<BookGenre>().ToTable("BookGenres");
            modelBuilder.Entity<BookGenre>().HasKey(bg => bg.ID);
            modelBuilder.Entity<BookGenre>().Property(bg => bg.ID);
            modelBuilder.Entity<BookGenre>().Property(bg => bg.BookID);
            modelBuilder.Entity<BookGenre>().Property(bg => bg.GenreID);
            modelBuilder.Entity<BookGenre>().Ignore(bg => bg.Book);
            modelBuilder.Entity<BookGenre>().Ignore(bg => bg.Genre);


            modelBuilder.Entity<BookTrope>().ToTable("BookTropes");
            modelBuilder.Entity<BookTrope>().HasKey(bt => bt.ID);
            modelBuilder.Entity<BookTrope>().Property(bt => bt.ID);
            modelBuilder.Entity<BookTrope>().Property(bt => bt.BookID);
            modelBuilder.Entity<BookTrope>().Property(bt => bt.TropeID);
            modelBuilder.Entity<BookTrope>().Ignore(bt => bt.Book);
            modelBuilder.Entity<BookTrope>().Ignore(bt => bt.Trope);

            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Genre>().HasKey(g => g.ID);
            modelBuilder.Entity<Genre>().Property(g => g.ID);
            modelBuilder.Entity<Genre>().Property(g => g.Name);

            modelBuilder.Entity<Trope>().ToTable("Tropes");
            modelBuilder.Entity<Trope>().HasKey(t => t.ID);
            modelBuilder.Entity<Trope>().Property(t => t.ID);
            modelBuilder.Entity<Trope>().Property(t => t.Name);
        }
    }
}
