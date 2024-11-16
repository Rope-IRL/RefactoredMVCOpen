namespace RefactoredMVC.Core.Models;

public class LandlordAdditionalInfo
{
    private LandlordAdditionalInfo(int id, string name, string surname, DateOnly birthDate,
        string telephone, string passportId, decimal averageMark)
    {
        Id = id;
        Name = name;
        Surname = surname;
        BirthDate = birthDate;
        Telephone = telephone;
        PassportId = passportId;
        AverageMark = averageMark;
    }
    
    public int Id { get; }

    public string Name { get; }

    public string Surname { get; }

    public DateOnly BirthDate { get; }

    public string Telephone { get; }

    public string PassportId { get; }

    public decimal AverageMark { get; }

    public static LandlordAdditionalInfo Create(int id, string name, string surname, DateOnly birthDate,
        string telephone, string passportId, decimal averageMark)
    {
        //validate methods
        
        LandlordAdditionalInfo landlordAdditionalInfo = new LandlordAdditionalInfo(id, name, surname, birthDate, telephone, passportId, averageMark);

        return landlordAdditionalInfo;
    }
}