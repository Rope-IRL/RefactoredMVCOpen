namespace RefactoredMVC.DataAccess.Entities;

public class LesseeEntity
{
    public int Id { get; set; }

    public string Login { get; set; }
    
    public string HashedPassword { get; set; }
    
    public string Email { get; set; }
    
    public LesseeAdditionalInfoEntity AdditionalInfo { get; set; }
    public List<FlatContractEntity>? FlatContracts { get; set; }
    
    public List<HouseContractEntity>? HouseContracts { get; set; }
    
    public List<RoomContractEntity>? RoomContracts { get; set; }
}