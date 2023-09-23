using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Context;
using HumanResource.Infrastructure.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Repositories.Concrete
{
    public class CompanyRepository : BaseEntityRepository<Company>, ICompanyRepository
    {
        private readonly HumanResourceDB resourceDB;

        protected DbSet<Company> table;
        public CompanyRepository(HumanResourceDB resourceDB) : base(resourceDB)
        {
            this.resourceDB = resourceDB;
            table = this.resourceDB.Set<Company>();
        }

        public async Task<bool> CompanyNameIsThere(string CompanyName)
        {
            Company company = await table.FirstOrDefaultAsync(x => x.Name == CompanyName);
            if (company == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<ICollection<Company>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<List<Company>> GetAllCompaniesAsync(Expression<Func<Company, bool>> predicate)
        {
            return await table.Where(x => x.Status != Status.Approval).ToListAsync();
        }

        public async Task<Company> GetCompanyDetailsAsync(int id)
        {
            var company = await table.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (company == null)
            {
                throw new Exception("Copmany is not found");

            }
            else
            {
                return company;
            }

        }
        public async Task<bool> TaxNoIsThere(string taxNo)
        {
            Company company = await table.FirstOrDefaultAsync(x => x.TaxNo == taxNo);
            if (company == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            Company company = await table.FirstOrDefaultAsync(x => x.Id == id);
            if(company == null)
            {
                throw new Exception("Company can not found.");
            }
            else
            {
                return company;
            }
        }
    }
}
