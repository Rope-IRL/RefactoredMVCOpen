namespace RefactoredMVC.DataAccess.Entities;

public class HotelEntity
{
    public int Id { get; set; }
    
    public string Header { get; set; }
    
    public string Description { get; set; }
    
    public decimal AverageMark { get; set; }
    
    public string City { get; set; }
    
    public string Address { get; set; }
    
    public int LlId { get; set; }
    
    public LandlordEntity? LandLord { get; set; }
    
    public List<RoomEntity>? HotelRooms { get; set; }
}