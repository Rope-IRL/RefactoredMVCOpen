namespace RefactoredMVC.Core.Models;

public class Hotel
{
    private Hotel(int id, string header, string description, decimal averageMark,
        string city, string address)
    {
        Id = id;
        Header = header;
        Description = description;
        City = city;
        Address = address;
        AverageMark = averageMark;
    }

    public int Id { get; }
    
    public string Header { get; }
    
    public string Description { get; }
    
    public decimal AverageMark { get; }

    public string City { get; }

    public string Address { get; }

    public static Hotel Create(int id, string header, string description, decimal averageMark, string city,
        string address)
    {
        //validate methods
        
        Hotel hotel = new Hotel(id, header, description, averageMark, city, address);

        return hotel;
    }
    
}