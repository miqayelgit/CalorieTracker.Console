using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CalorieTracker.Client.Configurations
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.RoleType)
                .IsRequired();

            builder.HasAlternateKey(x => x.RoleType)
                .HasName("UQ_Users_RoleType");

            builder.Property(x => x.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
