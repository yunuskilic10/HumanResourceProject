using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Repositories.Concrete
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly HumanResourceDB resourceDB;
        protected DbSet<PermissionDemand> table;

        public PermissionRepository(HumanResourceDB resourceDB)
        {
            this.resourceDB = resourceDB;
            table = this.resourceDB.Set<PermissionDemand>();
        }
        public async Task<bool> CreateAsync(PermissionDemand model)
        {
            try
            {

                await table.AddAsync(model);
                return await resourceDB.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException ex)
            {
                // InnerException'daki hata mesajını veya ayrıntıları yazdırabilirsiniz.
                Console.WriteLine("DbUpdateException: " + ex.InnerException?.Message);
                return false; // Hata durumunda false döndürün.
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

        public async Task<PermissionDemand> FindByInlclueAppUser(int id)
        {
            return await table.Include(x => x.AppUser).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<PermissionDemand>> GetAll(int id)
        {
            return await table.Where(x => x.AppUserId == id).ToArrayAsync();
        }

        public async Task<List<PermissionDemand>> GetAllActiveAsync(Expression<Func<PermissionDemand, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Active).ToListAsync();

        }
        public async Task<List<PermissionDemand>> GetAllActiveUserIdAsync(int id)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Active && x.AppUserId==id && (x.FemalePermissionType == FemalePermissionType.AnnualPaidLeave || x.MalePermissionType == MalePermissionType.AnnualPaidLeave)).ToListAsync();

        }

        public async Task<List<PermissionDemand>> GetAllApprovalAsync(Expression<Func<PermissionDemand, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Approval).ToListAsync();

        }
        public async Task<List<PermissionDemand>> GetAllApprovalUserIdAsync(int id)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Approval && x.AppUserId == id && (x.FemalePermissionType==FemalePermissionType.AnnualPaidLeave || x.MalePermissionType==MalePermissionType.AnnualPaidLeave)).ToListAsync();

        }

        public async Task<List<PermissionDemand>> GetAllPassiveAsync(Expression<Func<PermissionDemand, bool>> predicate)
        {
            return await table.Include(x => x.AppUser).Where(x => x.Status == Status.Passive).ToListAsync();

        }

        public async Task<PermissionDemand> GetByIdAsync(int id)
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

        public async Task<PermissionDemand> FindByInlclueAppUserAnnualPermission(int id)
        {
            var user = await table.Include(x => x.AppUser).Where(x => x.AppUserId == id).Where(x => x.Status != Status.Passive).Where(x => x.FemalePermissionType == FemalePermissionType.AnnualPaidLeave || x.MalePermissionType == MalePermissionType.AnnualPaidLeave).OrderBy(x => x.CreateDate).LastOrDefaultAsync();

           
                return user;
        }

        public async Task<PermissionDemand> FindByInlclueAppUserMaternitityPermission(int id)
        {
            var user = await table.Include(x => x.AppUser).Where(x => x.AppUserId == id).Where(x => x.Status != Status.Passive).Where(x => x.FemalePermissionType == FemalePermissionType.MaternityLeave || x.MalePermissionType == MalePermissionType.PaternityLeave).OrderBy(x => x.CreateDate).LastOrDefaultAsync();
            if (user==null)
            {
                PermissionDemand permissionDemand = new PermissionDemand();


                return permissionDemand;
            }

            return user;
        }

        public async Task<ICollection<PermissionDemand>> FindByInlclueAppUserApprovalPermissionList(int id)
        {
            return await table.Include(x => x.AppUser).Where(x => x.AppUserId == id).Where(x => x.Status == Status.Approval).ToListAsync();
        }

        public async Task<ICollection<PermissionDemand>> FindByInlclueAppUserActivePermissionList(int id)
        {
            return await table.Include(x => x.AppUser).Where(x => x.AppUserId == id).Where(x => x.Status == Status.Active).ToListAsync();
        }

        
    }
}
