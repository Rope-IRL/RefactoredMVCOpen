using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class HotelConfiguration : IEntityTypeConfiguration<HotelEntity>
{
    public void Configure(EntityTypeBuilder<HotelEntity> builder)
    {
        builder.HasKey(h => h.Id);
        builder.Property(h => h.Id).ValueGeneratedOnAdd();
        builder.Property(h => h.Header)
            .HasMaxLength(100);
        builder.Property(h => h.Header)
            .HasMaxLength(500);
        builder.Property(h => h.AverageMark).HasPrecision(2, 1);
        builder.Property(h => h.City).HasMaxLength(50);
        builder.Property(h => h.City).HasMaxLength(100);
        builder.HasOne(h => h.LandLord)
            .WithMany(ll => ll.Hotels)
            .OnDelete(DeleteBehavior.Cascade)
            .HasForeignKey(h => h.LlId);
        builder.HasMany(h => h.HotelRooms)
            .WithOne(hr => hr.Hotel);
    }
}