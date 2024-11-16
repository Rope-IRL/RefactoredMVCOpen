using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class LesseeMapper
    {
        public static Lessee ToDomain(LesseeEntity lesseeEntity)
        {
            Lessee lessee = Lessee.Create(lesseeEntity.Id, lesseeEntity.Login, lesseeEntity.HashedPassword, lesseeEntity.Email);
            return lessee;
        }

        public static LesseeEntity ToDataAccess(Lessee lessee)
        {
            LesseeEntity lesseeEntity = new LesseeEntity
            {
                Id = lessee.Id,
                Login = lessee.Login,
                HashedPassword = lessee.HashedPassword,
                Email = lessee.Email,
            };

            return lesseeEntity;
        }

    }
}
