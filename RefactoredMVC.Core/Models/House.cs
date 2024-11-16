namespace RefactoredMVC.Core.Models;

public class House
{
    private House(int id, string header, string description, decimal averageMark, 
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

    public static House Create(int id, string header, string description, decimal averageMark,
        string city, string address, short numberOfFloors, short numberOfRooms,
        bool isBathroomAvailable, bool isWiFiAvailable, decimal costPerDay)
    {
        //validate methods
        
        House house = new House(id, header, description, averageMark, city, address,numberOfFloors, numberOfRooms, isBathroomAvailable, isWiFiAvailable, costPerDay);
        
        return house;
    }
}