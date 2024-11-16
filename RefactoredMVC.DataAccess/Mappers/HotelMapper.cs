using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class HotelMapper
    {
        public static Hotel ToDomain(HotelEntity hotelEntity)
        {
            Hotel hotel = Hotel.Create(hotelEntity.Id, hotelEntity.Header, hotelEntity.Description, 
                hotelEntity.AverageMark, hotelEntity.City, hotelEntity.Address);

            return hotel;
        }

        public static HotelEntity ToDataAccess(Hotel hotel)
        {
            HotelEntity hotelEntity = new HotelEntity
            {
                Id = hotel.Id,
                Header = hotel.Header,
                Description = hotel.Description,
                AverageMark = hotel.AverageMark,
                City = hotel.City,
                Address = hotel.Address,

            };

            return hotelEntity;
        }

    }
}
