using HumanResource.Domain.Entities.Concrete;
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
    public class JobRepository:BaseEntityRepository<Job>, IJobRepository
    {
        private readonly HumanResourceDB resourceDB;
        protected DbSet<Job> table;

        public JobRepository(HumanResourceDB resourceDB) : base(resourceDB)
        {
            this.resourceDB = resourceDB;

            table = this.resourceDB.Set<Job>();
        }

        public async Task<ICollection<Job>> GetAll(int id)
        {

            return await table.Include(x => x.Department).ThenInclude(x=> x.Company).Where(x => x.Id == id).ToListAsync();
        }
    }
}
