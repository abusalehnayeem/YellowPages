using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YellowPages.DataAccess.EntityFramework
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        //http://www.itworld.com/article/2700950/development/a-generic-repository-for--net-entity-framework-6-with-async-operations.html
        #region Variable

        private readonly YellowPagesDbContext _context;
        private string _errorMessage;

        #endregion

        public BaseRepository(YellowPagesDbContext context)
        {
            _context = context;
        }

        #region Override Find and FindAsync Method

        public T Find(Expression<Func<T, bool>> match)
        {
            return _context.Set<T>().SingleOrDefault(match);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await _context.Set<T>().SingleOrDefaultAsync(match);
        }

        #endregion

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return null;
        }

        public T Insert(T entity)
        {
            return null;
        }

        public Task<T> InsertAsync(T entity)
        {
            return null;
        }

        public T Update(T entity)
        {
            return null;
        }

        public Task<T> UpdateAsync(T entity)
        {
            return null;
        }

        public T Delete(T entity)
        {
            return null;
        }

        public Task<T> DeleteAsync(T entity)
        {
            return null;
        }
    }
}