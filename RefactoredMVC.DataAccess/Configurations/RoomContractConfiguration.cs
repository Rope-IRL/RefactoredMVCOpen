using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class RoomContractConfiguration : IEntityTypeConfiguration<RoomContractEntity>
{
    public void Configure(EntityTypeBuilder<RoomContractEntity> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.StartDate);
        builder.Property(c => c.EndDate);
        builder.Property(c => c.Cost).HasPrecision(18, 2).HasColumnType("MONEY");
        builder.HasOne(c => c.Room)
            .WithMany(f => f.Contracts)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(c => c.RoomId);
        builder.HasOne(c => c.Landlord)
            .WithMany(ll => ll.RoomContracts);
        builder.HasOne(c => c.Lessee)
            .WithMany(l => l.RoomContracts);
    }
}