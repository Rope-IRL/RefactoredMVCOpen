using RefactoredMVC.Core.Models;
using RefactoredMVC.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMVC.DataAccess.Mappers
{
    public static class FlatContractMapper
    {
        public static FlatContractEntity ToDataAccess(FlatContract flatContract)
        {
            FlatContractEntity entity = new FlatContractEntity
            {
                Id = flatContract.Id,
                StartDate = flatContract.StartDate,
                EndDate = flatContract.EndDate,
                Cost = flatContract.Cost
            };

            return entity;
        }

        public static FlatContract ToDomain(FlatContractEntity flatContract)
        {
            FlatContract contract = FlatContract.Create(flatContract.Id, flatContract.StartDate, flatContract.EndDate, flatContract.Cost);

            return contract;
        }
    }
}
