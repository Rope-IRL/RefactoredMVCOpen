using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class HouseContractRepository(RentDbContext db) : IHouseContractRepository
{
    public async Task<List<HouseContract>> GetAllAsync()
    {
        var houseContracts = await db.HouseContracts.ToListAsync();
        return  houseContracts.Select(house => HouseContractMapper.ToDomain(house)).ToList();
    }

    public async Task<HouseContract> GetByIdAsync(int id)
    {
        var houseContract =  await db.HouseContracts.FirstOrDefaultAsync(house => house.Id == id);
        
        return HouseContractMapper.ToDomain(houseContract);
    }

    public async Task AddAsync(HouseContract houseContract)
    {
        var houseContractEntity = HouseContractMapper.ToDataAccess(houseContract);
        await db.HouseContracts.AddAsync(houseContractEntity);
        await db.SaveChangesAsync();
    }

    public async Task UpdateAsync(HouseContract houseContract)
    {
        var houseContractEntity = HouseContractMapper.ToDataAccess(houseContract);

        db.HouseContracts.Update(houseContractEntity);
        await db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var houseContract = await db.HouseContracts.FirstOrDefaultAsync(house => house.Id == id);
        db.HouseContracts.Remove(houseContract);
        await db.SaveChangesAsync();
    }
}