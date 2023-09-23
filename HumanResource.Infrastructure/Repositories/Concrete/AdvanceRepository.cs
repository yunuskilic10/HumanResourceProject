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
    public class AdvanceRepository : IAdvanceRepository
    {
        private readonly HumanResourceDB resourceDB;
        protected DbSet<AdvanceDemand> table;

        public AdvanceRepository(HumanResourceDB resourceDB)
        {
            this.resourceDB = resourceDB;
            table = this.resourceDB.Set<AdvanceDemand>();
        }
        public async Task<bool> CreateAsync(AdvanceDemand model)
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

        public bool Delete(int Id)
        {
            var model = table.FirstOrDefault(x => x.Id == Id);
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

        public async Task<AdvanceDemand> FindByInlclueAppUser(int id)
        {
            return await table.Include(x => x.AppUser).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<AdvanceDemand>> GetAll(int id)
        {
            return await table.Where(x => x.AppUserId == id).ToArrayAsync();
        }

        public async Task<List<AdvanceDemand>> GetAllActiveAsync(Expression<Func<AdvanceDemand, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Active).ToListAsync();
        }

        public async Task<List<AdvanceDemand>> GetAllApprovalAsync(Expression<Func<AdvanceDemand, bool>> predicate)
        {

            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Approval).ToListAsync();
        }

        public async Task<List<AdvanceDemand>> GetAllPassiveAsync(Expression<Func<AdvanceDemand, bool>> predicate)
        {

            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Passive).ToListAsync();
        }

        public async Task<AdvanceDemand> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<bool> AcceptToAsync(int id)
        {
            var entity = await table.FirstOrDefaultAsync(x => x.Id == id);
            try
            {
                entity.Status = Status.Active;
                entity.ResponseDate = DateTime.Now;
                table.Update(entity);
                return await resourceDB.SaveChangesAsync() > 0;
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

        public async Task<ICollection<AdvanceDemand>> FindByInlclueAppUserList(int id)
        {
            return await table.Include(x => x.AppUser).Where(x => x.AppUserId == id).Where(ad => ad.CreateDate >= DateTime.Now.AddYears(-1)).Where(x => x.Status == Status.Approval).ToListAsync();
                                                            
        }

        public async Task<ICollection<AdvanceDemand>> FindByInlclueAppUserApprovelList(int id)
        {
            return await table.Include(x => x.AppUser).Where(x => x.AppUserId == id).Where(ad => ad.ResponseDate >= DateTime.Now.AddYears(-1)).Where(x => x.Status == Status.Active).ToListAsync();
        }
    }
}
