using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class RoomContractMapper
    {
        public static RoomContract ToDomain(RoomContractEntity roomContractEntity)
        {
            RoomContract contract = RoomContract.Create(roomContractEntity.Id, roomContractEntity.StartDate, 
                roomContractEntity.EndDate, roomContractEntity.Cost);

            return contract;
        }

        public static RoomContractEntity ToDataAccess(RoomContract roomContract)
        {
            RoomContractEntity roomContractEntity = new RoomContractEntity
            {
                Id = roomContract.Id,
                StartDate = roomContract.StartDate,
                EndDate = roomContract.EndDate,
                Cost = roomContract.Cost,
            };

            return roomContractEntity;
        }
    }
}
