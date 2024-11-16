using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class FlatConfiguration : IEntityTypeConfiguration<FlatEntity>
{
    public void Configure(EntityTypeBuilder<FlatEntity> builder)
    {
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Id).ValueGeneratedOnAdd();
        builder.Property(f => f.Header)
            .HasMaxLength(100);
        builder.Property(f => f.Header)
            .HasMaxLength(500);
        builder.Property(f => f.AverageMark).HasPrecision(2, 1);
        builder.Property(f => f.City).HasMaxLength(50);
        builder.Property(f => f.Address).HasMaxLength(100);
        builder.Property(f => f.IsWiFiAvailable);
        builder.Property(f => f.IsBathroomAvailable);
        builder.Property(f => f.CostPerDay).HasPrecision(18, 2).HasColumnType("MONEY");
        builder.HasOne(f => f.LandLord)
            .WithMany(ll => ll.Flats)
            .HasForeignKey(f => f.LlId);
        builder.HasMany(f => f.Contracts)
            .WithOne(c => c.Flat);
    }
}