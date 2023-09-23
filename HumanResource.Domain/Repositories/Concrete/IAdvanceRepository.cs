using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Concrete
{
    public interface IAdvanceRepository
    {
        Task<bool> CreateAsync(AdvanceDemand model);
        bool Delete(int Id);
        Task<AdvanceDemand> GetByIdAsync(int id);

        Task<ICollection<AdvanceDemand>> GetAll(int id);
        Task<AdvanceDemand> FindByInlclueAppUser(int id);

        Task<ICollection<AdvanceDemand>> FindByInlclueAppUserList(int id);

        Task<ICollection<AdvanceDemand>> FindByInlclueAppUserApprovelList(int id);



        Task<List<AdvanceDemand>> GetAllActiveAsync(Expression<Func<AdvanceDemand, bool>> predicate);

        Task<List<AdvanceDemand>> GetAllPassiveAsync(Expression<Func<AdvanceDemand, bool>> predicate);
        Task<List<AdvanceDemand>> GetAllApprovalAsync(Expression<Func<AdvanceDemand, bool>> predicate);



        Task<bool> AcceptToAsync(int id);
        Task<bool> PassiveToAsync(int id);


    }
}
