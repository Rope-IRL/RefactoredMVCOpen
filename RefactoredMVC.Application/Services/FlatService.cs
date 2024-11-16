using RefactoredMVC.Application.Interfaces;
using RefactoredMVC.Core.Interfaces;
using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Application.Services
{
    public class FlatService(IFlatRepository repo) : IFlatService
    {
        public async Task<List<Flat>> GetFlats(int pageNumber, int pageSize)
        {
            List<Flat> flats = await repo.GetByPage(pageSize, pageNumber);

            //check if null

            return flats;
        }

        public async Task<List<Flat>> GetFullFlats(int pageNumber, int pageSize)
        {
            List<Flat> flats = await repo.GetFullByPage(pageSize, pageNumber);

            //check if null

            return flats;
        }

        public async Task<Flat> GetFlatById(int id)
        {
            Flat flat = await repo.GetFlatAsync(id);

            return flat;
        }

        public async Task AddFlat(Flat flat)
        {
            await repo.AddFlatAsync(flat);
        }

        public async Task UpdateFlat(Flat flat)
        {
            await repo.UpdateFlatAsync(flat);
        }

        public async Task DeleteFlat(int id)
        {
            await repo.DeleteFlatAsync(id);
        }

        public async Task<List<Flat>> GetFlatsByFilter(string city, decimal averageCost)
        {
            List<Flat> flats = await repo.GetByFilter(city, averageCost);
            return flats;
        }

    }
}
