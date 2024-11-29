using Microsoft.EntityFrameworkCore;
using WebApplication2;

namespace YourNamespace.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } // Replace with your actual DbSet
    }
}
