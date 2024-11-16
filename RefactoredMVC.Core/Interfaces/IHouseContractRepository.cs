using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface IHouseContractRepository
{
    public Task<List<HouseContract>> GetAllAsync();
    
    public Task<HouseContract> GetByIdAsync(int id);
    
    public Task AddAsync(HouseContract houseContract);
    
    public Task UpdateAsync(HouseContract houseContract);
    
    public Task DeleteAsync(int id);
}