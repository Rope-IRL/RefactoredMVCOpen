namespace RefactoredMVC.Core.Models;

public class Lessee
{
    private Lessee(int id, string login, string hashedPassword, string email)
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

    public static Lessee Create(int id, string login, string hashedPassword, string email)
    {
        //validate methods
        Lessee lessee = new Lessee(id, login, hashedPassword, email);

        return lessee;
    }
}