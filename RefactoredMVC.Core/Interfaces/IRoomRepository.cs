using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface IRoomRepository
{
    public Task<List<Room>> GetAllRoomsAsync();
    
    public Task<Room> GetRoomByIdAsync(int id);
    
    public Task AddRoomAsync(Room room);
    
    public Task UpdateRoomAsync(Room room);
    
    public Task DeleteRoomAsync(int id);
}