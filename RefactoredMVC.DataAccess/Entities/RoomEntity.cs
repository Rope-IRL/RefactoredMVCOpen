using System.ComponentModel.DataAnnotations;

namespace RefactoredMVC.DataAccess.Entities;

public class RoomEntity
{
    public int Id { get; set; }
    
    public string Header { get; set; }
    
    public string Description { get; set; }

    public bool IsBathroomAvailable { get; set; }

    public bool IsWiFiAvailable { get; set; }

    [DataType(DataType.Currency)]
    public decimal CostPerDay { get; set; }
    
    public int HouId { get; set; }
    
    public HotelEntity? Hotel { get; set; }
    
    public List<RoomContractEntity>? Contracts { get; set; }

}