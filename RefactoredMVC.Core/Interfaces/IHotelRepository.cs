using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface IHotelRepository
{
    public Task<List<Hotel>> GetAllHotels();
    
    public Task<Hotel> GetHotelById(int id);
    
    public Task AddHotel(Hotel hotel);
    
    public Task UpdateHotel(Hotel hotel);
    
    public Task DeleteHotel(int id);
}