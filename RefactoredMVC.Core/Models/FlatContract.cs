namespace RefactoredMVC.Core.Models;

public class FlatContract
{
    private FlatContract(int id, DateOnly startDate, DateOnly endDate, decimal cost)
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

    public static FlatContract Create(int id, DateOnly startDate, DateOnly endDate, decimal cost)
    {
        //validation methods
        
        FlatContract flatContract = new FlatContract(id, startDate, endDate, cost);

        return flatContract;
    }
}