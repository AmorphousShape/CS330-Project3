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

        public DbSet<ActorViewModel> Actors { get; set; }
        public DbSet<MovieViewModel> Movies { get; set; }
    }
}