using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalorieTracker.Client.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProductName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.ProteinPerHundredGram)
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.Property(x => x.FatPerHundredGram)
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.Property(x => x.CarbsPerHundredGram)
                .HasColumnType("FLOAT")
                .IsRequired();

            builder.Property(x => x.CaloriesPerHundredGram)
                .HasColumnType("SMALLINT")
                .IsRequired();

            builder.Property(x => x.VisibilityScope)
                .HasColumnType("TINYINT")
                .IsRequired();
        }
    }
}
