using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Concrete
{
    public interface ICompanyRepository : IMainRepository<Company>
    {
        
        Task<ICollection<Company>> GetAll();
        Task<bool> TaxNoIsThere(string taxNo);
        Task<bool> CompanyNameIsThere(string CompanyName);

        Task<List<Company>> GetAllCompaniesAsync(Expression<Func<Company, bool>> predicate);
        Task<Company> GetCompanyDetailsAsync(int id);
      
    }
}
