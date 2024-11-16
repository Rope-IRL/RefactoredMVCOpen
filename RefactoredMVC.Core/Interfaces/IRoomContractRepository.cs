using RefactoredMVC.Core.Models;

namespace RefactoredMVC.Core.Interfaces;

public interface IRoomContractRepository
{
    public Task<List<RoomContract>> GetAllRoomContractsAsync();

    public Task<RoomContract> GetRoomContractByIdAsync(int id);

    public Task AddRoomContractAsync(RoomContract roomContract);
    
    public Task UpdateRoomContractAsync(RoomContract roomContract);
    
    public Task DeleteRoomContractAsync(int id);
}