using CalorieTracker.Client.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTracker.Client.Configurations
{
    public class FitnessGoalEntityConfiguration : IEntityTypeConfiguration<FitnessGoal>
    {
        public void Configure(EntityTypeBuilder<FitnessGoal> builder)
        {
            builder.ToTable("FitnessGoals");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.GoalName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.GoalValue)
                .HasColumnType("FLOAT")
                .IsRequired();

            
        }
    }
}
