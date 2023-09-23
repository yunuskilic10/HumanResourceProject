using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Concrete
{
    public interface IPermissionRepository
    {
        Task<bool> CreateAsync(PermissionDemand model);
        bool Delete(int Id);
        Task<PermissionDemand> GetByIdAsync(int id);

        Task<ICollection<PermissionDemand>> GetAll(int id);
        Task<PermissionDemand> FindByInlclueAppUser(int id);

        Task<PermissionDemand> FindByInlclueAppUserMaternitityPermission(int id);
        Task<ICollection<PermissionDemand>> FindByInlclueAppUserApprovalPermissionList(int id);
        Task<PermissionDemand> FindByInlclueAppUserAnnualPermission(int id);
        Task<ICollection<PermissionDemand>> FindByInlclueAppUserActivePermissionList(int id);
        Task<List<PermissionDemand>> GetAllActiveAsync(Expression<Func<PermissionDemand, bool>> predicate);

        Task<List<PermissionDemand>> GetAllPassiveAsync(Expression<Func<PermissionDemand, bool>> predicate);
        Task<List<PermissionDemand>> GetAllApprovalAsync(Expression<Func<PermissionDemand, bool>> predicate);
        Task<List<PermissionDemand>> GetAllActiveUserIdAsync(int id);
        Task<List<PermissionDemand>> GetAllApprovalUserIdAsync(int id);

        Task<bool> AcceptToAsync(int id);
        Task<bool> PassiveToAsync(int id);
    }
}
