using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<RoomEntity>
{
    public void Configure(EntityTypeBuilder<RoomEntity> builder)
    {
        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id).ValueGeneratedOnAdd();
        builder.Property(r => r.Header).HasMaxLength(100);
        builder.Property(r => r.Description).HasMaxLength(500);
        builder.Property(r => r.CostPerDay).HasPrecision(18, 2);
        builder.Property(r => r.IsBathroomAvailable);
        builder.Property(r => r.IsWiFiAvailable);
        builder.Property(c => c.CostPerDay).HasPrecision(18, 2).HasColumnType("MONEY");
        builder.HasOne(r => r.Hotel)
            .WithMany(h => h.HotelRooms)
            .OnDelete(DeleteBehavior.Cascade)
            .HasForeignKey(r => r.HouId);
        builder.HasMany(r => r.Contracts)
            .WithOne(c => c.Room);
        
    }
}