using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class LandlordMapper
    {
        public static Landlord ToDomain(LandlordEntity landlordEntity)
        {
            Landlord landlord = Landlord.Create(landlordEntity.Id, landlordEntity.Login,
                landlordEntity.HashedPassword, landlordEntity.Email);

            return landlord;
        }

        public static LandlordEntity ToDataAccess(Landlord landlord)
        {
            LandlordEntity landlordEnity = new LandlordEntity
            {
                Id = landlord.Id,
                Login = landlord.Login,
                HashedPassword = landlord.HashedPassword,
                Email = landlord.Email,
            };

            return landlordEnity;
        }
    }
}
