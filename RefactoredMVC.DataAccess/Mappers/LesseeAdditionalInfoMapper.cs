using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class LesseeAdditionalInfoMapper
    {
        public static LesseeAdditionalInfo ToDomain(LesseeAdditionalInfoEntity lesseeEntity)
        {
            LesseeAdditionalInfo lesseeAdditionalInfo = LesseeAdditionalInfo.Create(lesseeEntity.Id, lesseeEntity.Name, lesseeEntity.Surname, 
                lesseeEntity.BirthDate, lesseeEntity.Telephone, lesseeEntity.PassportId, lesseeEntity.AverageMark);

            return lesseeAdditionalInfo;
        }

        public static LesseeAdditionalInfoEntity ToDataAccess(LesseeAdditionalInfo lesseeAdditionalInfo)
        {
            LesseeAdditionalInfoEntity lesseeAdditionalInfoEntity = new LesseeAdditionalInfoEntity
            {
                Id = lesseeAdditionalInfo.Id,
                Name = lesseeAdditionalInfo.Name,
                Surname = lesseeAdditionalInfo.Surname,
                BirthDate = lesseeAdditionalInfo.BirthDate,
                Telephone = lesseeAdditionalInfo.Telephone,
                PassportId = lesseeAdditionalInfo.PassportId,
                AverageMark = lesseeAdditionalInfo.AverageMark
            };

            return lesseeAdditionalInfoEntity;
        }
    }
}
