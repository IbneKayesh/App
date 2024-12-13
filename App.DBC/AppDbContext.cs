using App.DMO.Setup;
using Microsoft.EntityFrameworkCore;

namespace App.DBC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<BRAND> BRAND { get; set; }
    }
}
