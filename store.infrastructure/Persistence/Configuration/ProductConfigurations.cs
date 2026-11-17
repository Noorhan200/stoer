using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Domain.Entities;

namespace Store.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> b)
    {
        b.ToTable("Products");

        b.HasKey(p => p.Id);

        b.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

        b.Property(p => p.Price)
            .HasPrecision(18, 2);

        b.HasIndex(p => new { p.CategoryId, p.Name })
            .IsUnique();

        b.HasOne(p => p.Category)
            .WithMany(c => c.Prodects)
            .HasForeignKey(p => p.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}