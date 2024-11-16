namespace RefactoredMVC.Core.Models;

public class Flat
{
    private Flat(int id, string header, string description, decimal averageMark, 
        string city, string address, short numberOfFloors, short numberOfRooms,
        bool isBathroomAvailable, bool isWiFiAvailable, decimal costPerDay)
    {
        Id = id;
        Header = header;
        Description = description;
        City = city;
        Address = address;
        NumberOfRooms = numberOfRooms;
        NumberOfFloors = numberOfFloors;
        IsBathroomAvailable = isBathroomAvailable;
        IsWiFiAvailable = isWiFiAvailable;
        CostPerDay = costPerDay;
        AverageMark = averageMark;
    }
    
    public int Id { get; }
    
    public string Header { get; }
    
    public string Description { get; }
    
    public decimal AverageMark { get; }

    public string City { get; }

    public string Address { get; }

    public short NumberOfRooms { get; }

    public short NumberOfFloors { get;}

    public bool IsBathroomAvailable { get; }

    public bool IsWiFiAvailable { get; }

    public decimal CostPerDay { get; }

    public Landlord? LandLord { get; set; }

    public List<FlatContract>? Contracts { get; set; }

    public static Flat Create(int id, string header, string description, decimal averageMark, 
        string city, string address, short numberOfFloors, short numberOfRooms,
        bool isBathroomAvailable, bool isWiFiAvailable, decimal costPerDay)
    {
        //validation methods
        
        Flat flat = new Flat(id, header, description, averageMark,
            city, address, numberOfRooms, numberOfFloors,
            isBathroomAvailable, isWiFiAvailable, costPerDay);
        return flat;
    }

    public void AddDetails(Landlord landlord, List<FlatContract> contracts)
    {
        LandLord = landlord;
        Contracts = contracts;
    }
    
}