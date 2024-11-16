using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class FlatContractRepository(RentDbContext db) : IFlatContractRepository
{
    public async Task<List<FlatContract>> GetFlatContractsAsync()
    {
        var flatContracts = await db.FlatContracts.ToListAsync();
        return  flatContracts.Select(flat => FlatContractMapper.ToDomain(flat)).ToList();
    }

    public async Task<FlatContract> GetFlatContractByIdAsync(int id)
    {
        var flatContract =  await db.FlatContracts.FirstOrDefaultAsync(flat => flat.Id == id);
        
        return FlatContractMapper.ToDomain(flatContract);
    }

    public async Task AddFlatContractAsync(FlatContract flatContract)
    {
        var flatContractEntity = FlatContractMapper.ToDataAccess(flatContract);
        await db.FlatContracts.AddAsync(flatContractEntity);
        await db.SaveChangesAsync();
    }

    public async Task UpdateFlatContractAsync(FlatContract flatContract)
    {
        var flatContractEntity = FlatContractMapper.ToDataAccess(flatContract);

        db.FlatContracts.Update(flatContractEntity);
        await db.SaveChangesAsync();
    }

    public async Task DeleteFlatContractAsync(int id)
    {
        var flatContract = await db.FlatContracts.FirstOrDefaultAsync(flat => flat.Id == id);
        db.FlatContracts.Remove(flatContract);
        await db.SaveChangesAsync();
    }
}