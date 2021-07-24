using Domain.Entity;
using Infrastructure.Context.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasKey(x => x.Id);

            //Seeds
            modelBuilder.Entity<Vehicle>().HasData(VehicleSeed.Seeds);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
