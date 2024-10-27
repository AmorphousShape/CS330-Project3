using Microsoft.EntityFrameworkCore;
using Fall2024_Assignment3_jbmcclenny.Models;

namespace Fall2024_Assignment3_jbmcclenny.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MovieViewModel> Movie { get; set; } = default!;
        public DbSet<ActorViewModel> Actor { get; set; } = default!;
    }
}
