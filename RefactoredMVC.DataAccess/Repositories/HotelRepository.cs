using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class HotelRepository(RentDbContext db) : IHotelRepository
{
    public async Task<List<Hotel>> GetAllHotels()
    {
        var hotels = await db.Hotels.ToListAsync();
        
        return hotels.Select(hotel => HotelMapper.ToDomain(hotel)).ToList();
    }

    public async Task<Hotel> GetHotelById(int id)
    {
        var hotel = await db.Hotels.FirstOrDefaultAsync(hotel => hotel.Id == id);

        return HotelMapper.ToDomain(hotel);
    }

    public async Task AddHotel(Hotel hotel)
    {
        var hotelModel = HotelMapper.ToDataAccess(hotel);
        
        await db.Hotels.AddAsync(hotelModel);
        await db.SaveChangesAsync();
    }

    public async Task UpdateHotel(Hotel hotel)
    {
        var hotelModel = HotelMapper.ToDataAccess(hotel);

        db.Hotels.Update(hotelModel);
        await db.SaveChangesAsync();
    }

    public async Task DeleteHotel(int id)
    {
        var hotel = await db.Hotels.FirstOrDefaultAsync(hotel => hotel.Id == id);
        db.Hotels.Remove(hotel);
        await db.SaveChangesAsync();
    }
}