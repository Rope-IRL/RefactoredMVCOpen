using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class FlatRepository(RentDbContext db) : IFlatRepository
{
    public async Task<List<Flat>> GetAllFlatsAsync()
    {
        var flats = await db.Flats.ToListAsync();
        return  flats.Select(flat => FlatMapper.ToDomain(flat))
            .ToList();
    }

    public async Task<List<Flat>> GetAllFlatsFullAsync()
    {
        var flats = await db.Flats.ToListAsync();
        return flats.Select(flat => FlatMapper.ToDomainFull(flat))
            .ToList();
    }

    public async Task<Flat> GetFlatAsync(int id)
    {
        var flat = await db.Flats.FindAsync(id);
        return FlatMapper.ToDomain(flat);
    }

    public async Task AddFlatAsync(Flat flat)
    {
        var flatModel = FlatMapper.ToDataAccess(flat);
        await db.Flats.AddAsync(flatModel);
        await db.SaveChangesAsync();
    }

    public async Task UpdateFlatAsync(Flat flat)
    {
        var flatModel = FlatMapper.ToDataAccess(flat);

        db.Flats.Update(flatModel);
        await db.SaveChangesAsync();
    }
    

    public async Task DeleteFlatAsync(int id)
    {
        var flat = await db.Flats.FirstOrDefaultAsync(f => f.Id == id);
        db.Flats.Remove(flat);
        await db.SaveChangesAsync();
    }

    public async Task<List<Flat>> GetByPage(int pageSize, int pageNumber)
    {
        List<FlatEntity> flatEntities = await db.Flats.Skip((pageNumber-1) * pageSize).Take(pageSize).ToListAsync();

        return flatEntities.Select(flat => FlatMapper.ToDomain(flat)).ToList();
    }

    public async Task<List<Flat>> GetFullByPage(int pageSize, int pageNumber)
    {
        List<FlatEntity> flatEntities = await db.Flats
            .Include(f => f.LandLord)
            .ThenInclude(ll => ll.AdditionalInfo)
            .Include(f => f.Contracts)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return flatEntities.Select(flat => FlatMapper.ToDomainFull(flat)).ToList();
    }

    public async Task<List<Flat>> GetByFilter(string city, decimal averageCost)
    {
        var q = db.Flats.AsNoTracking();

        if (string.IsNullOrEmpty(city))
        {
            q = q.Where(f => f.City == city);
        }

        if (averageCost > 0)
        {
            q = q.Where(flat => flat.CostPerDay > averageCost);
        }

        return await q.Select(flat => FlatMapper.ToDomain(flat)).ToListAsync();
    }
}