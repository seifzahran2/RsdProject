using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RsdProject.Models;
using TestRSD.Models;

namespace TestRSD.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedingRoles(modelBuilder);
        }

        

        private void SeedingRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "fab4fac1-c546-41de-aebc-a14da6895711", Name = "sa7pMasla7a", ConcurrencyStamp = "1", NormalizedName = "Sa7pMasla7a" }
                
                );
        }


        public DbSet<Accept> Accepts { get; set; }
        public DbSet<DrugSell> drugSells { get; set; }
        public DbSet<DeactivateUnit> deactivateUnits { get; set; }
        public DbSet<DeactivationCancel> deactivationCancels { get; set; }
        public DbSet<DrugSellCancle> drugSellCancles { get; set; }
        public DbSet<Return> returns { get; set; }
        public DbSet<Transfer> transfers { get; set; }
        public DbSet<TransferCancle> transferCancles { get; set; }

    }
}
