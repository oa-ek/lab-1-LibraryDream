using LibraryDream.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryDream.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set;}
    }
}