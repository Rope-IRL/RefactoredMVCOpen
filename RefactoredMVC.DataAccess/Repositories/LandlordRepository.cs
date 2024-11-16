using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories
{
    public class LandlordRepository(RentDbContext db) : ILandlordRepository
    {
        public async Task AddAsync(Landlord landLord)
        {
            LandlordEntity landlordEntity = LandlordMapper.ToDataAccess(landLord);

            await db.AddAsync(landlordEntity);
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            LesseeEntity landLord = await db.Lessees.FirstOrDefaultAsync(l => l.Id == id);
            db.Remove(landLord);
            await db.SaveChangesAsync();
        }

        public async Task<List<Landlord>> GetAllAsync()
        {
            var lessees = await db.Landlords.ToListAsync();

            return lessees.Select(landLord => LandlordMapper.ToDomain(landLord)).ToList();
        }

        public async Task<Landlord> GetByIdAsync(int id)
        {
            var landLord = await db.Landlords.FirstOrDefaultAsync(landLord => landLord.Id == id);

            return LandlordMapper.ToDomain(landLord);
        }

        public async Task UpdateAsync (Landlord landLord)
        {
            LandlordEntity landlordEntity = LandlordMapper.ToDataAccess(landLord);

            db.Update(landlordEntity);
            await db.SaveChangesAsync();
        }
    }
}
