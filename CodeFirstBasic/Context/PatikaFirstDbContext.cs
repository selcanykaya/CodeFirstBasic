using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
    "Server=localhost\\SQLEXPRESS;Database=PatikaCodeFirst1;Trusted_Connection=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);
        }
    

    public DbSet<MovieEntity> Movies => Set<MovieEntity>();
    public DbSet<GameEntity> Games => Set<GameEntity>();

    }
}