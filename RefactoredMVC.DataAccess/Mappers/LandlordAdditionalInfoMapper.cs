using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class LandlordAdditionalInfoMapper
    {
        public static LandlordAdditionalInfo ToDomain(LandlordAdditionalInfoEntity landlordAdditionalInfoEntity)
        {
            LandlordAdditionalInfo lanLordAdditionalInfo = LandlordAdditionalInfo.Create(landlordAdditionalInfoEntity.Id, landlordAdditionalInfoEntity.Name, 
                landlordAdditionalInfoEntity.Surname, landlordAdditionalInfoEntity.BirthDate, landlordAdditionalInfoEntity.Telephone,
                landlordAdditionalInfoEntity.PassportId, landlordAdditionalInfoEntity.AverageMark);
            return lanLordAdditionalInfo;
        }

        public static LandlordAdditionalInfoEntity ToDataAccess(LandlordAdditionalInfo landlordAdditionalInfo)
        {
            LandlordAdditionalInfoEntity landlordAdditionalInfoEntity = new LandlordAdditionalInfoEntity
            {
                Id = landlordAdditionalInfo.Id,
                Name = landlordAdditionalInfo.Name,
                Surname = landlordAdditionalInfo.Surname,
                BirthDate = landlordAdditionalInfo.BirthDate,
                Telephone = landlordAdditionalInfo.Telephone,
                PassportId = landlordAdditionalInfo.PassportId,
                AverageMark = landlordAdditionalInfo.AverageMark
            };

            return landlordAdditionalInfoEntity;
        }

    }
}
