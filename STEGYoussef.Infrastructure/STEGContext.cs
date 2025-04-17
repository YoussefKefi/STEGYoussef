using Microsoft.EntityFrameworkCore;
using STEGYoussef.Infrastructure.Configurations;
using STEGYoussef.ApplicationCore.Domains;
using STEGYoussef.Infrastructure.Configurations;

namespace STEGYoussef.Infrastructure
{
    public class STEGContext : DbContext
    {
        public DbSet<Abonne> Abonnes { get; set; }
        public DbSet<Compteur> Compteurs { get; set; }
        public DbSet<Periode> Periodes { get; set; }
        public DbSet<Facture> Factures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog=STEGYoussefKefi;
                                        Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations )3-a

            
            modelBuilder.ApplyConfiguration(new FactureConfiguration());

            // Set composite key for Facture )3-b

            modelBuilder.Entity<Facture>()
                .HasKey(f => new { f.CompteurKey, f.PeriodeKey, f.Date });

            base.OnModelCreating(modelBuilder);

            // Set max length for all string properties )3-c

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(string))
                    {
                        property.SetMaxLength(200);
                    }
                }
            }

            
        }
    }
}