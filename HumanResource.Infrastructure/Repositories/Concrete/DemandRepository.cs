using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Repositories.Concrete
{
    public class DemandRepository : IDemandRepository
    {
        private readonly HumanResourceDB resourceDB;
        protected DbSet<SalaryRequest> table;
        public DemandRepository(HumanResourceDB resourceDB)
        {
            this.resourceDB = resourceDB;
            table = this.resourceDB.Set<SalaryRequest>();
        }
        public async Task<bool> CreateAsync(SalaryRequest model)
        {
            try
            {

                await table.AddAsync(model);
                return await resourceDB.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {

            var model = table.FirstOrDefault(x => x.Id == id);
            try
            {
                table.Remove(model);
                return resourceDB.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<SalaryRequest> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }
        public async Task<SalaryRequest> FindByInlclueAppUser(int id)
        {
            return await table.Include(x => x.AppUser).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<SalaryRequest>> GetAll(int id)
        {
            return await table.Where(x => x.AppUserId == id).ToArrayAsync();
        }

        public async Task<List<SalaryRequest>> GetAllActiveAsync(Expression<Func<SalaryRequest, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Active).ToListAsync();

        }

        public async Task<List<SalaryRequest>> GetAllPassiveAsync(Expression<Func<SalaryRequest, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Passive).ToListAsync();

        }

        public async Task<List<SalaryRequest>> GetAllApprovalAsync(Expression<Func<SalaryRequest, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Approval).ToListAsync();

        }

        public async Task<bool> AcceptToAsync(int id)
        {
            var entity = await table.FirstOrDefaultAsync(x => x.Id == id);
            try
            {
                entity.Status = Status.Active;
                entity.ResponseDate = DateTime.Now;
                table.Update(entity);
                return await resourceDB.SaveChangesAsync()>0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> PassiveToAsync(int id)
        {
            var entity = await table.FirstOrDefaultAsync(x => x.Id == id);
            try
            {
                entity.Status = Status.Passive;
                entity.ResponseDate = DateTime.Now;
                table.Update(entity);
                return await resourceDB.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
