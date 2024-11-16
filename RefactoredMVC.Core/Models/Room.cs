namespace RefactoredMVC.Core.Models;

public class Room
{
    private Room(int id, string header, string description,
        bool isWiFiAvailable, bool isBathroomAvailable, decimal costPerDay)
    {
        Id = id;
        Header = header;
        Description = description;
        IsWiFiAvailable = isWiFiAvailable;
        IsBathroomAvailable = isBathroomAvailable;
        CostPerDay = costPerDay;
    }
    
    public int Id { get;}
    
    public string Header { get; }
    
    public string Description { get; }

    public bool IsBathroomAvailable { get; }

    public bool IsWiFiAvailable { get; }

    public decimal CostPerDay { get; }

    public static Room Create(int id, string header, string description,
        bool isWiFiAvailable, bool isBathroomAvailable, decimal costPerDay)
    {
        //validate methods
        
        Room room = new Room(id, header, description, isWiFiAvailable, isBathroomAvailable, costPerDay);
        
        return room;
    }
}