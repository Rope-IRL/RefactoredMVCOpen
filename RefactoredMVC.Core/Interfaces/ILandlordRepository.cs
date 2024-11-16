using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface ILandlordRepository
{
    public Task<List<Landlord>> GetAllAsync();
    
    public Task<Landlord> GetByIdAsync(int id);
    
    public Task AddAsync(Landlord landlord);
    
    public Task UpdateAsync(Landlord landlord);
    
    public Task DeleteAsync(int id);
}