namespace RefactoredMVC.Core.Models;

public class Landlord
{
    private Landlord(int id, string login, string hashedPassword, string email)
    {
        Id = id;
        Login = login;
        HashedPassword = hashedPassword;
        Email = email;
    }
    
    public int Id { get;}

    public string Login { get;}
    
    public string HashedPassword { get; }
    
    public string Email { get; }

    public static Landlord Create(int id, string login, string hashedPassword, string email)
    {
        //validate methods
        
        Landlord landlord = new Landlord(id, login, hashedPassword, email);

        return landlord;
    }
}