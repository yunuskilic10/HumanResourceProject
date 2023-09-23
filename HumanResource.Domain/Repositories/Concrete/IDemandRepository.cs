using HumanResource.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Concrete
{
    public interface IDemandRepository
    {
        Task<bool> CreateAsync(SalaryRequest model);
        bool Delete(int id);
        Task<SalaryRequest> GetByIdAsync(int id);
       
        Task<ICollection<SalaryRequest>> GetAll(int id);
        Task<SalaryRequest> FindByInlclueAppUser(int id);
        Task<List<SalaryRequest>> GetAllActiveAsync(Expression<Func<SalaryRequest, bool>> predicate);

        Task<List<SalaryRequest>> GetAllPassiveAsync(Expression<Func<SalaryRequest, bool>> predicate);
        Task<List<SalaryRequest>> GetAllApprovalAsync(Expression<Func<SalaryRequest, bool>> predicate);

        Task<bool> AcceptToAsync(int id);
        Task<bool> PassiveToAsync(int id);
    }
}
