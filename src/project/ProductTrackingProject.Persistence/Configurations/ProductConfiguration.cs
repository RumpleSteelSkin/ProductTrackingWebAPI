using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductTrackingProject.Domain.Entities;
namespace ProductTrackingProject.Persistence.Configurations;
public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(500)
            .HasColumnName("Name");

        builder.Property(x => x.Price)
            .HasPrecision(18, 2);

        builder.Navigation(x => x.Category).AutoInclude();
        
        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}