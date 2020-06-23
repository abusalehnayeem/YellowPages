using System;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace YellowPages.Entities.Extensions
{
    public static class EfExtensions
    {
        public static async Task<T> FindAsync<T>(this IDbSet<T> queryable, Expression<Func<T, bool>> match)
            where T : class
        {
            if (queryable == null) throw new ArgumentNullException(nameof(queryable));
            return await queryable.SingleOrDefaultAsync(match);
        }
    }
}