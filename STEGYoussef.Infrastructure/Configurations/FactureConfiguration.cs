using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using STEGYoussef.ApplicationCore.Domains;

namespace STEGYoussef.Infrastructure.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            // Configure relationship between Compteur, Periode and Facture
            builder.HasOne(f => f.Compteur)
                .WithMany(c => c.Factures)
                .HasForeignKey(f => f.CompteurKey)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(f => f.Periode)
                .WithMany(p => p.Factures)
                .HasForeignKey(f => f.PeriodeKey)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}