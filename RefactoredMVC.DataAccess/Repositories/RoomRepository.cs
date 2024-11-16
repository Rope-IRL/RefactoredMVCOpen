using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class RoomRepository(RentDbContext db) : IRoomRepository
{
    public async Task<List<Room>> GetAllRoomsAsync()
    {
        var rooms = await db.Rooms.ToListAsync();
        
        return rooms.Select(room => RoomMapper.ToDomain(room)).ToList();
    }

    public async Task<Room> GetRoomByIdAsync(int id)
    {
        RoomEntity roomEntity = await db.Rooms.FirstOrDefaultAsync(room => room.Id == id);

        return RoomMapper.ToDomain(roomEntity);
    }

    public async Task AddRoomAsync(Room room)
    {
        RoomEntity roomEntity = RoomMapper.ToDataAccess(room);

        await db.Rooms.AddAsync(roomEntity);
        await db.SaveChangesAsync();
    }

    public async Task UpdateRoomAsync(Room room)
    {
        RoomEntity roomEntity = RoomMapper.ToDataAccess(room);

        db.Rooms.Update(roomEntity);
        await db.SaveChangesAsync();
    }

    public async Task DeleteRoomAsync(int id)
    {
        RoomEntity roomEntity = db.Rooms.FirstOrDefault(room => room.Id == id);
        db.Rooms.Remove(roomEntity);
        await db.SaveChangesAsync();
    }
}