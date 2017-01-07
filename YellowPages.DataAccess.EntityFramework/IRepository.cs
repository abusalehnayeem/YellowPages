using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YellowPages.DataAccess.EntityFramework
{
    public interface IRepository<T> where T:class
    {

        List<T> GetAll();
        Task<List<T>> GetAllAsync();
         
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        
        T Insert(T entity);
        Task<T> InsertAsync(T entity);

        T Update(T entity);
        Task<T> UpdateAsync(T entity);

        T Delete(T entity);
        Task<T> DeleteAsync(T entity);
    }
}