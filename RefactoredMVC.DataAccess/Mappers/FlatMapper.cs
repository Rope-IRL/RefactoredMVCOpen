using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class FlatMapper
    {
        public static FlatEntity ToDataAccess(Flat flat)
        {
            FlatEntity entity = new FlatEntity
            {
                Id = flat.Id,
                Header = flat.Header,
                Description = flat.Description,
                AverageMark = flat.AverageMark,
                City = flat.City,
                Address = flat.Address,
                NumberOfRooms = flat.NumberOfRooms,
                NumberOfFloors = flat.NumberOfFloors,
                IsBathroomAvailable = flat.IsBathroomAvailable,
                IsWiFiAvailable = flat.IsWiFiAvailable,
                CostPerDay = flat.CostPerDay
            };

            return entity;
        }

        public static Flat ToDomain(FlatEntity flat)
        {
            Flat flatModel = Flat.Create(flat.Id, flat.Header, flat.Description,flat.AverageMark, flat.City,
                flat.Address, flat.NumberOfFloors, flat.NumberOfRooms, flat.IsBathroomAvailable,
                flat.IsWiFiAvailable, flat.CostPerDay);

            return flatModel;
        }

        public static Flat ToDomainFull(FlatEntity flat)
        {
            Flat flatModel = Flat.Create(flat.Id, flat.Header, flat.Description, flat.AverageMark, flat.City,
                flat.Address, flat.NumberOfFloors, flat.NumberOfRooms, flat.IsBathroomAvailable,
                flat.IsWiFiAvailable, flat.CostPerDay);

            flatModel.AddDetails(LandlordMapper.ToDomain(flat.LandLord),
                flat.Contracts.Select(contract => FlatContractMapper.ToDomain(contract)).ToList());

            return flatModel;

        }
    }
}
