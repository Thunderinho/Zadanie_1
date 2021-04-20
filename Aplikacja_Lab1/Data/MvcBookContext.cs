using Aplikacja_Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcBook.Data
{
    public class MvcBookContext : DbContext
    {
        public MvcBookContext(DbContextOptions<MvcBookContext> options)
        : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
    }
}
