namespace RefactoredMVC.DataAccess.Entities;

public class LandlordAdditionalInfoEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public DateOnly BirthDate { get; set; }

    public string Telephone { get; set; }

    public string PassportId { get; set; }

    public decimal AverageMark { get; set; }
    
    public int LandlordId {get; set;}
    
    public LandlordEntity? Landlord {get; set;}
}