using HumanResource.Applications.Models.DTOs.AdminDTO;
using HumanResource.Applications.Models.DTOs.PersonnelDTO;
using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Applications.Services.Admin.Abstact
{
    public interface ICompanyService
    {
        Task<ICollection<AdminListCompanyDTO>> GetAllCompanies(Expression<Func<AdminListCompanyDTO, bool>> predicate);
        Task<AdminDetailCompanyDTO> DetailPost(int Id);
        Task<bool> CreateCompanyPost(AdminAddCompanyDTO model);
        Task<ICollection<AdminListCompanyDTO>> GetListCompany();
        Task<AdminDetailCompanyDTO> GetCompanyDetails(int id);
        Task<Company> GetByIdAsync(int id);
    }
}
