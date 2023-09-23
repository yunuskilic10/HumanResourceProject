using HumanResource.Domain.Entities.Concrete;
using HumanResource.Domain.Repositories.Abstract;
using HumanResource.Domain.Repositories.Concrete;
using HumanResource.Infrastructure.Context;
using HumanResource.Infrastructure.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Repositories.Concrete
{
    public class AppUserRepository : IPersonnelRepository
    {
        private readonly HumanResourceDB resourceDB;
        private readonly RoleManager<AppRole> roleManager;
        private readonly UserManager<AppUser> userManager;
        protected DbSet<AppUser> table;

        public AppUserRepository(HumanResourceDB resourceDB, RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            this.resourceDB = resourceDB;
            this.roleManager = roleManager;
            this.userManager = userManager;
            table = this.resourceDB.Set<AppUser>();
        }

        public async Task<bool> CreateAsync(AppUser entity)
        {
            try
            {

                await table.AddAsync(entity);
                return await resourceDB.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> DeleteAsync(AppUser entity)
        {
            try
            {
                entity.Status = Domain.Enums.Status.Passive;
                return await resourceDB.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<AppUser> FindByIdIncludeDetail(int id)
        {
            return await table.Include(x => x.Job).Include(x => x.Company).Include(x => x.Department).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<AppUser>> GetAllFirstOrDefaultsAsync(Expression<Func<AppUser, bool>> predicate)
        {
            return await table.Where(predicate).ToListAsync();
        }



        public async Task<IEnumerable<AppUser>> GetAllListAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<AppUser> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<ICollection<AppUser>> GetCompanyManagerList(string rolename)
        {
            return await userManager.GetUsersInRoleAsync(rolename);

        }

        public async Task<ICollection<AppUser>> GetCompanyPersonels(int id)
        {
            return await table.Where(x => x.CompanyId == id).ToListAsync();
        }
        public async Task<ICollection<AppUser>> GetDepartmendPersonelList(int id, int departmendId)
        {
            return await table.Where(x => x.CompanyId == id && x.DepartmentId == departmendId).ToListAsync();
        }
        public async Task<AppUser> GetFirstOrDefaultAsync(Expression<Func<AppUser, bool>> predicate)
        {
            return await table.FirstOrDefaultAsync(predicate);
        }

        public async Task<ICollection<AppUser>> GetJobPersonellList(int id, int jobId)
        {
            return await table.Where(x => x.CompanyId == id && x.JobId == jobId).ToListAsync();
        }

        public async Task<bool> UpdateAsync(AppUser entity)
        {
            try
            {
                table.Update(entity);
                return await resourceDB.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> UserIdIsThere(string identity)
        {
            var user = await table.FirstOrDefaultAsync(x => x.IdentityNumber == identity);
            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UserMailIsThere(string mail)
        {
            var user = await table.FirstOrDefaultAsync(x => x.PrivateMail == mail);
            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UserPhoneIsThere(string phoneNumber)
        {
            var user = await table.FirstOrDefaultAsync(x => x.PhoneNumber == phoneNumber);
            if (user == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
