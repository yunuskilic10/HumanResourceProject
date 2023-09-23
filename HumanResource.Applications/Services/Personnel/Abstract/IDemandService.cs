using HumanResource.Applications.Models.DTOs.AdvanceDTO;
using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Abstract
{
    public interface IDemandService
    {
        Task<bool> CreateDemandPost(CreateDemandDTO model);
        Task CreateDemand();

        Task<ICollection<ListDemandDTO>> ListDemand(int Id);
        bool DeleteDemandPost(int Id);

        Task<bool> ActiveDemandPost(int Id);
        Task<bool> PassiveDemandPost(int Id);
        Task<ICollection<ListDemandDTO>> ListDemandActive(Expression<Func<ListDemandDTO, bool>> predicate);
        Task<ICollection<ListDemandDTO>> ListDemandApproval(Expression<Func<ListDemandDTO, bool>> predicate);
        Task<ICollection<ListDemandDTO>> ListDemandPassive(Expression<Func<ListDemandDTO, bool>> predicate);

    }
}
