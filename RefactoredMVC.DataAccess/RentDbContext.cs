using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RefactoredMVC.DataAccess.Configurations;
using RefactoredMVC.DataAccess.Entities;

namespace RefactoredMVC.DataAccess;

public class RentDbContext(IConfiguration configuration) : DbContext
{
    public DbSet<FlatEntity> Flats { get; set; }
    
    public DbSet<FlatContractEntity> FlatContracts { get; set; }
    
    public DbSet<HouseEntity> Houses { get; set; }
    
    public DbSet<HouseContractEntity> HouseContracts { get; set; }
    
    public DbSet<HotelEntity> Hotels { get; set; }
    
    public DbSet<RoomEntity> Rooms { get; set; }
    
    public DbSet<RoomContractEntity> RoomContracts { get; set; }
    
    public DbSet<LandlordEntity> Landlords { get; set; }
    
    public DbSet<LandlordAdditionalInfoEntity> LandlordAdditionalInfos { get; set; }
    
    public DbSet<LesseeEntity> Lessees { get; set; }
    
    public DbSet<LesseeAdditionalInfoEntity> LesseeAdditionalInfos { get; set; }

    protected override  void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LesseeConfiguration());
        modelBuilder.ApplyConfiguration(new LesseeAdditionalInfoConfiguration());
        modelBuilder.ApplyConfiguration(new LandlordConfiguration());
        modelBuilder.ApplyConfiguration(new LandlordAdditionalInfoConfiguration());
        modelBuilder.ApplyConfiguration(new FlatConfiguration());
        modelBuilder.ApplyConfiguration(new FlatContractConfiguration());
        modelBuilder.ApplyConfiguration(new HouseConfiguration());
        modelBuilder.ApplyConfiguration(new HouseContractConfiguration());
        modelBuilder.ApplyConfiguration(new HotelConfiguration());
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
        modelBuilder.ApplyConfiguration(new RoomContractConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("MsSqlConnection"));
    }
}