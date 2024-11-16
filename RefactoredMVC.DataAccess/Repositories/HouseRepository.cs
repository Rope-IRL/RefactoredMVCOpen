using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class HouseRepository(RentDbContext db) : IHouseRepository
{
    public async Task<List<House>> GetAllAsync()
    {
        var houses = await db.Houses.ToListAsync();
        return  houses.Select(house => HouseMapper.ToDomain(house))
            .ToList();
    }

    public async Task<House> GetByIdAsync(int id)
    {
        var house = await db.Houses.FindAsync(id);
        return HouseMapper.ToDomain(house);
    }

    public async Task AddAsync(House house)
    {
        var houseModel = HouseMapper.ToDataAccess(house);
        await db.Houses.AddAsync(houseModel);
        await db.SaveChangesAsync();
    }

    public async Task UpdateAsync(House house)
    {
        var houseModel = HouseMapper.ToDataAccess(house);
        db.Houses.Update(houseModel);
        await db.SaveChangesAsync();
    }
    

    public async Task DeleteAsync(int id)
    {
        var house = await db.Houses.FirstOrDefaultAsync(h => h.Id == id);
        db.Houses.Remove(house);
        await db.SaveChangesAsync();
    }
}