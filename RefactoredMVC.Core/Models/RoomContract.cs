namespace RefactoredMVC.Core.Models;

public class RoomContract
{
    private RoomContract(int id, DateOnly startDate, DateOnly endDate, decimal cost)
    {
        Id = id;
        StartDate = startDate;
        EndDate = endDate;
        Cost = cost;
    }
    
    public int Id { get;}
    
    public DateOnly StartDate { get; }
    
    public DateOnly EndDate { get; }
    
    public decimal Cost { get; }

    public static RoomContract Create(int id, DateOnly startDate, DateOnly endDate, decimal cost)
    {
        //validate methods
        
        RoomContract roomContract = new RoomContract(id, startDate, endDate, cost);
        
        return roomContract;
    }
}