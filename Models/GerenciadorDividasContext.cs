using Microsoft.EntityFrameworkCore;

namespace GerenciadorDividasCore.Models
{
    public class GerenciadorDividasContext : DbContext
    {
        public DbSet<Divida> Dividas { get; set; }

        public GerenciadorDividasContext(DbContextOptions<GerenciadorDividasContext> options): base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Divida>()
                .HasKey(p => p.Id);
        }
    }
}