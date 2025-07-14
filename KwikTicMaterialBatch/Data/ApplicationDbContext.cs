using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KwikTicMaterialBatch.Data.Models;

namespace KwikTicMaterialBatch.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Material> Materials { get; set; } = null!; // Ensure that the DbSet seed is initialized
        public DbSet<Kit> Kits { get; set; }
        public DbSet<Batch> Batches { get; set; }
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
                 },
                 new Material
                 {
                     MaterialID = 3,
                     MaterialSerialNumber = "SN-0003",
                     MaterialName = "Inductor-1mH",
                     MaterialDescription = "1mH Inductor Coil",
                     Quantity = 150,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 4,
                     MaterialSerialNumber = "SN-0004",
                     MaterialName = "Diode-1N4007",
                     MaterialDescription = "General Purpose Diode",
                     Quantity = 600,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 5,
                     MaterialSerialNumber = "SN-0005",
                     MaterialName = "Transistor-BC547",
                     MaterialDescription = "NPN Bipolar Junction Transistor",
                     Quantity = 250,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 6,
                     MaterialSerialNumber = "SN-0006",
                     MaterialName = "LED-Red",
                     MaterialDescription = "5mm Red LED",
                     Quantity = 1000,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 7,
                     MaterialSerialNumber = "SN-0007",
                     MaterialName = "IC-NE555",
                     MaterialDescription = "Timer IC NE555",
                     Quantity = 200,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 8,
                     MaterialSerialNumber = "SN-0008",
                     MaterialName = "Connector-Header",
                     MaterialDescription = "Male Header Pins 40-pin",
                     Quantity = 350,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 9,
                     MaterialSerialNumber = "SN-0009",
                     MaterialName = "Switch-Toggle",
                     MaterialDescription = "Mini Toggle Switch SPDT",
                     Quantity = 120,
                     AllUsed = false,
                     KitId = null
                 },
                 new Material
                 {
                     MaterialID = 10,
                     MaterialSerialNumber = "SN-0010",
                     MaterialName = "Potentiometer-10K",
                     MaterialDescription = "10K Rotary Potentiometer",
                     Quantity = 180,
                     AllUsed = false,
                     KitId = null
                 }
            );

        }
    }
}
