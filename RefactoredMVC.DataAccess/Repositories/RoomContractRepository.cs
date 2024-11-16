using Microsoft.EntityFrameworkCore;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using RefactoredMVC.DataAccess.Mappers;
using RefactoredMVC.Core.Interfaces;

namespace RefactoredMVC.DataAccess.Repositories;

public class RoomContractRepository(RentDbContext db) : IRoomContractRepository
{
    public async Task<List<RoomContract>> GetAllRoomContractsAsync()
    {
        var roomContracts = await db.RoomContracts.ToListAsync();
    
        return roomContracts.Select(room => RoomContractMapper.ToDomain(room)).ToList();
    }

    public async Task<RoomContract> GetRoomContractByIdAsync(int id)
    {
        RoomContractEntity roomContractEntity = await db.RoomContracts.FirstOrDefaultAsync(room => room.Id == id);

        return RoomContractMapper.ToDomain(roomContractEntity);
    }

    public async Task AddRoomContractAsync(RoomContract roomContract)
    {
        RoomContractEntity roomContractEntity = RoomContractMapper.ToDataAccess(roomContract);

        await db.AddAsync(roomContractEntity);
        await db.SaveChangesAsync();
    }

    public async Task UpdateRoomContractAsync(RoomContract roomContract)
    {
        RoomContractEntity roomContractEntity = RoomContractMapper.ToDataAccess(roomContract);

        db.RoomContracts.Update(roomContractEntity);
        await db.SaveChangesAsync();
    }

    public async Task DeleteRoomContractAsync(int id)
    {
        RoomContractEntity roomContractEntity = await db.RoomContracts.FirstOrDefaultAsync(room => room.Id == id);

        db.RoomContracts.Remove(roomContractEntity);
        await db.SaveChangesAsync();
    }
}