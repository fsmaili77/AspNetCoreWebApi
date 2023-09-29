using CitiesManager.Core.Identity;
using CitiesManager.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.Infrastructure.DatabaseContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        // DbContext  contsructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        public virtual DbSet<City> Cities { get; set; }

        // Create sample seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City()
            {
                //Convert string to Guid
                CityID = Guid.Parse("04206C4E-B0A7-48F2-9159-27BDDDDC748C"), 
                CityName = "Paris"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityID = Guid.Parse("7EEFEBE3-5A43-4A89-818E-1C8AE50EC847"),
                CityName = "London"
            });
        }
    }
}
