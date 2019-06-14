using Microsoft.EntityFrameworkCore;

namespace ipb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}

        public DbSet<List> Listy { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<List>().Property(l => l.Stan).HasConversion(x => (int) x, x => (Stan) x);
            modelBuilder.Entity<List>().Property(l => l.CzyPowazny).HasConversion<int>();
        }

    }
}