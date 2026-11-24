using CarRentalManagemant.Configurations.Entities;
using CarRentalManagement.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; 

namespace CarRentalManagemant.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    public DbSet<CarRentalManagement.Domain.Customer> Customer { get; set; } = default!;
    public DbSet<CarRentalManagemant.Domain.Booking> Booking { get; set; } = default!;
    public DbSet<CarRentalManagemant.Domain.Vehicle> Vehicle { get; set; } = default!;
    public DbSet<CarRentalManagemant.Domain.Colour> Colour { get; set; } = default!;
    public DbSet<CarRentalManagemant.Domain.Model> Model { get; set; } = default!;
    public DbSet<CarRentalManagemant.Domain.Make> Make { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }

    }
}
