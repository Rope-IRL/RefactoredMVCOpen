using RefactoredMVC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.Application.Interfaces
{
    public interface IFlatService
    {
        public Task<List<Flat>> GetFlats(int pageNumber, int pageSize);

        public Task<List<Flat>> GetFullFlats(int pageNumber, int pageSize);

        public Task<Flat> GetFlatById(int id);

        public Task AddFlat(Flat flat);

        public Task UpdateFlat(Flat flat);

        public Task DeleteFlat(int id);

        public Task<List<Flat>> GetFlatsByFilter(string city, decimal averageCost);
    }
}
