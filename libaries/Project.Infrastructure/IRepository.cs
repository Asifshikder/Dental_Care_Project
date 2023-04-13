using Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> FindByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<bool> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        void AddRange(IEnumerable<T> entities);
        Task<bool> RemoveAsync(T entity);
        Task<bool> RemoveByIdAsync(long id);
        void RemoveRange(IEnumerable<T> entities);
    }
}
