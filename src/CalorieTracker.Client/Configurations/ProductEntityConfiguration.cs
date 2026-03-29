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
                .IsRequired();

            builder.Property(x => x.FatPerHundredGram)
                .IsRequired();

            builder.Property(x => x.CarbsPerHundredGram)
                .IsRequired();

            builder.Property(x => x.CaloriesPerHundredGram)
                .IsRequired();

            builder.Property(x => x.VisibilityScope)
                .IsRequired();

            builder.HasOne(x => x.User)
                   .WithMany(u => u.Products)
                   .HasForeignKey(x => x.UserId);
        }
    }
}
