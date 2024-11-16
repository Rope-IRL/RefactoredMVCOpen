using System.ComponentModel.DataAnnotations;

namespace RefactoredMVC.DataAccess.Entities;

public class HouseContractEntity
{
    public int Id { get; set; }
    
    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    [DataType(DataType.Currency)]
    public decimal Cost { get; set; }
    
    public int HouseId { get; set; }
    
    public HouseEntity? House { get; set; }
    
    public int LandlordId { get; set; }
    
    public LandlordEntity? Landlord { get; set; }
    
    public int LesseeId { get; set; }
    
    public LesseeEntity? Lessee { get; set; }
}