using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface IHouseRepository
{
    public Task<List<House>> GetAllAsync();
    
    public Task<House> GetByIdAsync(int id);
    
    public Task AddAsync(House house);
    
    public Task UpdateAsync(House house);
    
    public Task DeleteAsync(int id);
}