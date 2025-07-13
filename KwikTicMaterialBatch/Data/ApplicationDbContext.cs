using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Material> Materials { get; set; } = null!; // Ensure that the DbSet is initialized
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed some basic Material data
            modelBuilder.Entity<Material>().HasData(
                new Material
                {
                    MaterialID = 1,
                    MaterialSerialNumber = "SN-0001",
                    MaterialName = "Resistor-10K",
                    MaterialDescription = "10K Ohm Resistor",
                    Quantity = 500,
                    AllUsed = false,
                    KitId = null
                },
                new Material
                {
                    MaterialID = 2,
                    MaterialSerialNumber = "SN-0002",
                    MaterialName = "Capacitor-100uF",
                    MaterialDescription = "100uF Electrolytic Capacitor",
                    Quantity = 300,
                    AllUsed = false,
                    KitId = null
                }
            );
        }
    }
}
