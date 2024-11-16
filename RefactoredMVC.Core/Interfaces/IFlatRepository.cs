using RefactoredMVC.Core.Models;


namespace RefactoredMVC.Core.Interfaces;

public interface IFlatRepository
{
    public Task<List<Flat>> GetAllFlatsAsync();
    public Task<List<Flat>> GetAllFlatsFullAsync();
    public Task<Flat> GetFlatAsync(int id);
    public Task AddFlatAsync(Flat flat);
    public Task UpdateFlatAsync(Flat flat);
    public Task DeleteFlatAsync(int id);
    public Task<List<Flat>> GetByPage(int pageSize, int pageNumber);
    public Task<List<Flat>> GetFullByPage(int pageSize, int pageNumber);
    public Task<List<Flat>> GetByFilter(string city, decimal averageCost);
}