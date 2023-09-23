using HumanResource.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResource.Domain.Repositories.Abstract
{
    public interface IMainRepository<T> where T : class, IGodEntity
    {
        Task<bool> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllListAsync();

        /// <summary>
        /// Id'ye göre entity dönen metot.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate);        //id ye gore bul
        /// <summary>
        /// Şarta göre liste dönene metot.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<List<T>> GetAllFirstOrDefaultsAsync(Expression<Func<T, bool>> predicate);


    }
}
