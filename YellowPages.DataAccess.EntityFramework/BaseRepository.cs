using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using YellowPages.Entities.Repositories;

namespace YellowPages.DataAccess.EntityFramework
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public BaseRepository(YellowPagesDbContext context)
        {
            _context = context;
        }

        protected DbSet<T> Set => _set ?? (_set = _context.Set<T>());

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> PageAllAsync(int skip, int take)
        {
            return await Set.Skip(skip).Take(take).ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await Set.FindAsync(id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            Set.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity, object key)
        {
            if (entity == null)
                return null;

            var existing = await Set.FindAsync(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }

            return existing;
        }

        public async Task<int> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }
        //http://www.itworld.com/article/2700950/development/a-generic-repository-for--net-entity-framework-6-with-async-operations.html

        #region Variable

        private readonly YellowPagesDbContext _context;
        private DbSet<T> _set;

        #endregion
    }
}