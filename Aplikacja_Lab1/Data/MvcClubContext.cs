using Aplikacja_Lab1.Models;
using Microsoft.EntityFrameworkCore;

namespace MvcClub.Data
{
    public class MvcClubContext : DbContext
    {
        public MvcClubContext(DbContextOptions<MvcClubContext> options)
        : base(options)
        {
        }
        public DbSet<Club> Club { get; set; }
    }
}