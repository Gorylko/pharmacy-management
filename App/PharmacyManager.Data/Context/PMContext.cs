using Microsoft.EntityFrameworkCore;
using PharmacyManager.Shared.Entities;

namespace PharmacyManager.Data.Context
{
    public class PMContext : DbContext
    {
        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<User> Users { get; set; }

        public PMContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
