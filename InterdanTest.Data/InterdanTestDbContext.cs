using InterdanTest.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InterdanTest.Data
{
    public class InterdanTestDbContext: DbContext
    {
        public InterdanTestDbContext(DbContextOptions<InterdanTestDbContext> options)
            : base(options)
        {
        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<CarColor> CarColors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
