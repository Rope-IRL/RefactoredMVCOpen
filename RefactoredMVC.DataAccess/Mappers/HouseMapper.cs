using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class HouseMapper
    {
        public static House ToDomain(HouseEntity houseEntity)
        {
            House house = House.Create(houseEntity.Id, houseEntity.Header, houseEntity.Description, houseEntity.AverageMark, houseEntity.City,
                houseEntity.Address, houseEntity.NumberOfFloors, houseEntity.NumberOfRooms,
                houseEntity.IsBathroomAvailable, houseEntity.IsWiFiAvailable, houseEntity.CostPerDay);

            return house;
        }

        public static HouseEntity ToDataAccess(House house)
        {
            HouseEntity houseEntity = new HouseEntity
            {
                Id = house.Id,
                Header = house.Header,
                Description = house.Description,
                AverageMark = house.AverageMark,
                City = house.City,
                Address = house.Address,
                NumberOfRooms = house.NumberOfRooms,
                NumberOfFloors = house.NumberOfFloors,
                IsBathroomAvailable = house.IsBathroomAvailable,
                IsWiFiAvailable = house.IsWiFiAvailable,
                CostPerDay = house.CostPerDay
            };
            return houseEntity;
        }
    }
}
