namespace RefactoredMVC.Core.Models;

public class HouseContract
{
    private HouseContract(int id, DateOnly startDate, DateOnly endDate, decimal cost)
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

    public static HouseContract Create(int id, DateOnly startDate, DateOnly endDate, decimal cost)
    {
        //validate mehtods

        HouseContract houseContract = new HouseContract(id, startDate, endDate, cost);
        
        return houseContract;
    }
}