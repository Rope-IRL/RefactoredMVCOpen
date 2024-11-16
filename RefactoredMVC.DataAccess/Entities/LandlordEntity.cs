using System.Data.Common;

namespace RefactoredMVC.DataAccess.Entities;

public class LandlordEntity
{
    public int Id { get; set; }

    public string Login { get; set; }
    
    public string HashedPassword { get; set; }
    
    public string Email { get; set; }
    
    public List<FlatEntity>? Flats { get; set; }
    
    public List<FlatContractEntity>? FlatContracts { get; set; }
    
    public List<HouseEntity>? Houses { get; set; }
    
    public List<HouseContractEntity>? HouseContracts { get; set; }
    
    public List<HotelEntity>? Hotels { get; set; }
    
    public List<RoomContractEntity>? RoomContracts { get; set; }
    
    public LandlordAdditionalInfoEntity AdditionalInfo { get; set; }
}