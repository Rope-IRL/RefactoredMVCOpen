using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class RoomMapper
    {
        public static Room ToDomain(RoomEntity roomEntity)
        {
            Room room = Room.Create(roomEntity.Id, roomEntity.Header, roomEntity.Description, roomEntity.IsWiFiAvailable,
            roomEntity.IsBathroomAvailable, roomEntity.CostPerDay);

            return room;
        }

        public static RoomEntity ToDataAccess(Room room)
        {
            RoomEntity roomEntity = new RoomEntity
            {
                Id = room.Id,
                Header = room.Header,
                Description = room.Description,
                CostPerDay = room.CostPerDay,
                IsBathroomAvailable = room.IsBathroomAvailable,
                IsWiFiAvailable = room.IsWiFiAvailable,
            };

            return roomEntity;
        }

    }
}
