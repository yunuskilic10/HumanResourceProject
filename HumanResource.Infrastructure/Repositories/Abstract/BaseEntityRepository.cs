using HumanResource.Domain.Entities.Abstract;
using HumanResource.Domain.Enums;
using HumanResource.Domain.Repositories.Abstract;
using HumanResource.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Infrastructure.Repositories.Abstract
{
    public class BaseEntityRepository<T> : IMainRepository<T> where T : class, IGodEntity
    {
        private readonly HumanResourceDB resourceDb;
        protected DbSet<T> table;

        public BaseEntityRepository(HumanResourceDB resourceDb)
        {
            this.resourceDb = resourceDb;
            table = this.resourceDb.Set<T>();
        }

        public async Task<bool> CreateAsync(T entity)
        {
            try
            {
                await table.AddAsync(entity);
                return await resourceDb.SaveChangesAsync()>0;
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine("hata: " + ex.InnerException?.Message);
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            try
            {
                entity.Status = Status.Passive;
                return await resourceDb.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<T>> GetAllFirstOrDefaultsAsync(Expression<Func<T, bool>> predicate)
        {
            return await table.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllListAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await table.FirstOrDefaultAsync(predicate);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            try
            {
                table.Update(entity);
                return await resourceDb.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
