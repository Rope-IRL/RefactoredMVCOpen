using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface IFlatContractRepository
{
    public Task<List<FlatContract>> GetFlatContractsAsync();
    
    public Task<FlatContract> GetFlatContractByIdAsync(int id);
    
    public Task AddFlatContractAsync(FlatContract flatContract);
    
    public Task UpdateFlatContractAsync(FlatContract flatContract);
    
    public Task DeleteFlatContractAsync(int id);
}