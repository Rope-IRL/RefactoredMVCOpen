using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories
{
    public class LesseeAdditionalInfoRepository(RentDbContext db) : ILesseeAdditionalInfoRepository
    {
        public async Task AddLesseeAdditionalInfo(LesseeAdditionalInfo lesseeAdditionalInfo)
        {
            LesseeAdditionalInfoEntity info = LesseeAdditionalInfoMapper.ToDataAccess(lesseeAdditionalInfo);

            db.AddAsync(info);
            await db.SaveChangesAsync();

        }

        public async Task DeleteLesseeAdditionalInfo(int id)
        {
            LesseeAdditionalInfoEntity info = await db.LesseeAdditionalInfos.FirstOrDefaultAsync(l => l.Id == id);

            db.Remove(info);
            await db.SaveChangesAsync();
        }

        public async Task<List<LesseeAdditionalInfo>> GetAllLesseeAdditionalInfos()
        {
            var addInfos = await db.LesseeAdditionalInfos.ToListAsync();

            return addInfos.Select(info => LesseeAdditionalInfoMapper.ToDomain(info)).ToList();
        }

        public async Task<LesseeAdditionalInfo> GetLesseeAdditionalInfoById(int id)
        {
            LesseeAdditionalInfoEntity info = await db.LesseeAdditionalInfos.FirstOrDefaultAsync(l => l.Id == id);

            return LesseeAdditionalInfoMapper.ToDomain(info);
        }

        public async Task UpdateLesseeAdditionalInfo(LesseeAdditionalInfo lesseeAdditionalInfo)
        {
            LesseeAdditionalInfoEntity info = LesseeAdditionalInfoMapper.ToDataAccess(lesseeAdditionalInfo);

            db.Update(info);
            await db.SaveChangesAsync();
        }
    }
}
