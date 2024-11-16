using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess.Configurations;

public class LesseeAdditionalInfoConfiguration : IEntityTypeConfiguration<LesseeAdditionalInfoEntity>
{
    public void Configure(EntityTypeBuilder<LesseeAdditionalInfoEntity> builder)
    {
        builder.HasKey(li => li.Id);
        builder.Property(li => li.Id).ValueGeneratedOnAdd();
        builder.Property(li => li.Name).HasMaxLength(20);
        builder.Property(li => li.Surname).HasMaxLength(30);
        builder.Property(li => li.Telephone).HasMaxLength(25);
        builder.Property(li => li.PassportId).HasMaxLength(40);
        builder.Property(li => li.AverageMark).HasPrecision(2, 1);
        builder.HasOne(li => li.Lessee)
            .WithOne(l => l.AdditionalInfo);
    }
}