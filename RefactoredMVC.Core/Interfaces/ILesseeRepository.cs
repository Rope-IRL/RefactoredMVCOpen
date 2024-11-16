using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface ILesseeRepository
{
    public Task<List<Lessee>> GetAllLessees();
    
    public Task<Lessee> GetLessee(int id);
    
    public Task AddLessee(Lessee lessee);
    
    public Task UpdateLessee(Lessee lessee);
    
    public Task DeleteLessee(int id);
}