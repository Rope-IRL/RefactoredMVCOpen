using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class HouseConfiguration : IEntityTypeConfiguration<HouseEntity>
{
    public void Configure(EntityTypeBuilder<HouseEntity> builder)
    {
        builder.HasKey(h => h.Id);
        builder.Property(h => h.Id).ValueGeneratedOnAdd();
        builder.Property(h => h.Header)
            .HasMaxLength(100);
        builder.Property(h => h.Header)
            .HasMaxLength(500);
        builder.Property(h => h.AverageMark).HasPrecision(2, 1);
        builder.Property(h => h.City).HasMaxLength(50);
        builder.Property(h => h.Address).HasMaxLength(100);
        builder.Property(h => h.IsWiFiAvailable);
        builder.Property(h => h.IsBathroomAvailable);
        builder.Property(h => h.CostPerDay).HasPrecision(18, 2).HasColumnType("MONEY");
        builder.HasOne(h => h.LandLord)
            .WithMany(ll => ll.Houses)
            .OnDelete(DeleteBehavior.Cascade)
            .HasForeignKey(h => h.LlId);
        builder.HasMany(h => h.Contracts)
            .WithOne(c => c.House);
    }
}