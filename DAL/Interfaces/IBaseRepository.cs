using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
    {
        IQueryable<T> FindAll();
        void Delete(T entity);
        Task<T?> FirstOrDefaultAsync();
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task CreateAsync(T entity);
        void Create(T entity);
    }
}
