using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Abstract
{
    public interface IPersonnelRepository : IMainRepository<AppUser>
    {
        Task<AppUser> FindByIdIncludeDetail(int id);
        Task<ICollection<AppUser>> GetCompanyPersonels(int id);
        Task<ICollection<AppUser>> GetDepartmendPersonelList(int id, int departmendId);
        Task<ICollection<AppUser>> GetJobPersonellList(int id, int jobId);
        Task<ICollection<AppUser>> GetCompanyManagerList(string rolename);
        Task<bool> UserIdIsThere(string identity);
        Task<bool> UserPhoneIsThere(string phoneNumber);

        Task<bool> UserMailIsThere(string mail);

    }
}
