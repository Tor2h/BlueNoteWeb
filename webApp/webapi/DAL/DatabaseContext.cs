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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Book>().HasKey(b => b.ID);
            modelBuilder.Entity<Book>().HasMany(b => b.BookGenres).WithOne(bg => bg.Book).HasForeignKey(bt => bt.BookID);
            modelBuilder.Entity<Book>().HasMany(b => b.BookTropes).WithOne(bt => bt.Book).HasForeignKey(bt => bt.BookID);

            modelBuilder.Entity<BookGenre>().ToTable("BookGenres");
            modelBuilder.Entity<BookGenre>().HasKey(bg => bg.ID);
            modelBuilder.Entity<BookGenre>().HasOne(bg => bg.Book).WithMany(b => b.BookGenres).HasForeignKey(bg => bg.BookID);
            modelBuilder.Entity<BookGenre>().HasOne(bg => bg.Genre).WithMany(g => g.BookGenres).HasForeignKey(bg => bg.GenreID);

            modelBuilder.Entity<BookTrope>().ToTable("BookTropes");
            modelBuilder.Entity<BookTrope>().HasKey(bt => bt.ID);
            modelBuilder.Entity<BookTrope>().HasOne(bt => bt.Book).WithMany(b => b.BookTropes).HasForeignKey(bt => bt.BookID);
            modelBuilder.Entity<BookTrope>().HasOne(bt => bt.Trope).WithMany(t => t.BookTropes).HasForeignKey(bt => bt.TropeID);

            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Genre>().HasKey(g => g.ID);

            modelBuilder.Entity<Trope>().ToTable("Tropes");
            modelBuilder.Entity<Trope>().HasKey(t => t.ID);
        }
    }
}
