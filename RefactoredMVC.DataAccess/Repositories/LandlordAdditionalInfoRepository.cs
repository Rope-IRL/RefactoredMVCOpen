using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;


namespace RefactoredMVC.DataAccess.Repositories
{
    public class LandlordAdditionalInfoRepository(RentDbContext db) : ILandlordAdditionalInfoRepository
    {
        public async Task AddAdditionalInfoAsync(LandlordAdditionalInfo landlordAdditionalInfo)
        {
            LandlordAdditionalInfoEntity info = LandlordAdditionalInfoMapper.ToDataAccess(landlordAdditionalInfo);

            await db.AddAsync(info);
            await db.SaveChangesAsync();

        }

        public async Task DeleteAdditionalInfoAsync(int id)
        {
            LandlordAdditionalInfoEntity info = await db.LandlordAdditionalInfos.FirstOrDefaultAsync(l => l.Id == id);

            db.Remove(info);
            await db.SaveChangesAsync();
        }

        public async Task<List<LandlordAdditionalInfo>> GetAdditionalInfosAsync()
        {
            var addInfos = await db.LandlordAdditionalInfos.ToListAsync();

            return addInfos.Select(info => LandlordAdditionalInfoMapper.ToDomain(info)).ToList();
        }

        public async Task<LandlordAdditionalInfo> GetAdditionalInfoByIdAsync(int id)
        {
            LandlordAdditionalInfoEntity info = await db.LandlordAdditionalInfos.FirstOrDefaultAsync(l => l.Id == id);

            return LandlordAdditionalInfoMapper.ToDomain(info);
        }

        public async Task UpdateAdditionalInfoAsync(LandlordAdditionalInfo landlordAdditionalInfo)
        {
            LandlordAdditionalInfoEntity info = LandlordAdditionalInfoMapper.ToDataAccess(landlordAdditionalInfo);

            db.Update(info);
            await db.SaveChangesAsync();
        }
    }
}
