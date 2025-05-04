using Jcf.AM.Control.Api.Extensions;
using Jcf.AM.Control.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jcf.AM.Control.Api.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
