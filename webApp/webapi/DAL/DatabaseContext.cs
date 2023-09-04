using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.DAL
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("ConnectMsSqlString");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Trope> Tropes { get; set; }
    }
}
