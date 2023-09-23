using HumanResource.Applications.Models.DTOs.DemandDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Personnel.Abstract
{
    public interface IPersonnelService
    {
        Task<SummaryDTO> SummaryCompanyPost(int id);
        Task<SummaryDTO> SummaryPost(int id);
        Task<DetailDTO> DetailPost(int id);
        Task<DetailDTO> DetailCompanyManagerPost(int id);
        Task<UpdateDTO> ManagerUpdate(int id);

        Task<UpdateDTO> Update(int id);
        Task<bool> UpdatePost(UpdateDTO model);
        Task<IdentityResult> CreatePersonnelPost(CreateDTO model, int id,int departmentid,int jobid);
        Task<IdentityResult> CreateCompanyManagerPost(CreateDTO model);
        Task<ICollection<ListDTO>> GetCompanyPersonels(int id);
        Task<ICollection<ListDTO>> GetPersonelList(int id, int departmendId);
        Task<ICollection<ListDTO>> GetPersonelJobList(int id, int jobid);
        Task<ICollection<ListDTO>> GetInRolePersonelList(string rolename);


    }
}
