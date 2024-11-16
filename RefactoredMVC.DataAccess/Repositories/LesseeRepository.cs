using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories
{
    public class LesseeRepository(RentDbContext db) : ILesseeRepository
    {
        public async Task AddLessee(Lessee lessee)
        {
            LesseeEntity lesseeEntity = LesseeMapper.ToDataAccess(lessee);

            await db.AddAsync(lesseeEntity);
            await db.SaveChangesAsync();
        }

        public async Task DeleteLessee(int id)
        {
            LesseeEntity lessee = await db.Lessees.FirstOrDefaultAsync(l => l.Id == id);
            db.Remove(lessee);
            await db.SaveChangesAsync();
        }

        public async Task<List<Lessee>> GetAllLessees()
        {
            var lessees = await db.Lessees.ToListAsync();

            return lessees.Select(lessee => LesseeMapper.ToDomain(lessee)).ToList();
        }

        public async Task<Lessee> GetLessee(int id)
        {
            var lessee = await db.Lessees.FirstOrDefaultAsync(lessee => lessee.Id == id);

            return LesseeMapper.ToDomain(lessee);
        }

        public async Task UpdateLessee(Lessee lessee)
        {
            LesseeEntity lesseeEntity = LesseeMapper.ToDataAccess(lessee);

            db.Update(lesseeEntity);
            await db.SaveChangesAsync();
        }
    }
}
