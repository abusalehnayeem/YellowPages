using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace YellowPages.Entities.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> PageAllAsync(int skip, int take);
        Task<T> GetByIdAsync(object id);
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity, object key);
        Task<int> DeleteAsync(T entity);
        Task<int> CountAsync();
    }
}