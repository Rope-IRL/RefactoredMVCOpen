using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class FlatContractConfiguration : IEntityTypeConfiguration<FlatContractEntity>
{
    public void Configure(EntityTypeBuilder<FlatContractEntity> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).ValueGeneratedOnAdd();
        builder.Property(c => c.StartDate);
        builder.Property(c => c.EndDate);
        builder.Property(c => c.Cost).HasPrecision(18, 2).HasColumnType("MONEY");
        builder.HasOne(c => c.Flat)
            .WithMany(f => f.Contracts)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(c => c.FlatId);
        builder.HasOne(c => c.Landlord)
            .WithMany(ll => ll.FlatContracts)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(f => f.LandlordId);
        builder.HasOne(c => c.Lessee)
            .WithMany(l => l.FlatContracts)
            .OnDelete(DeleteBehavior.Restrict)
            .HasForeignKey(f => f.LesseeId);
    }
}