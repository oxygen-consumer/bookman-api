using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
    : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many to many relationship between Book and Author
            modelBuilder.Entity<BookAuthor>()
                .HasKey(ba => new { ba.BookId, ba.AuthorId });
        }
        public DbSet<API.Models.Category> Category { get; set; } = default!;
    }
}
