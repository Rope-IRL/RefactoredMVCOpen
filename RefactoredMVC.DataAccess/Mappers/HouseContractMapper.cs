using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class HouseContractMapper
    {
        public static HouseContract ToDomain(HouseContractEntity contractEntity)
        {
            HouseContract contract = HouseContract.Create(contractEntity.Id, contractEntity.StartDate, contractEntity.EndDate, contractEntity.Cost);
            return contract;
        }

        public static HouseContractEntity ToDataAccess(HouseContract contract)
        {
            HouseContractEntity contractEntity = new HouseContractEntity
            {
                Id = contract.Id,
                StartDate = contract.StartDate,
                EndDate = contract.EndDate,
                Cost = contract.Cost
            };

            return contractEntity;
        }
    }
}
