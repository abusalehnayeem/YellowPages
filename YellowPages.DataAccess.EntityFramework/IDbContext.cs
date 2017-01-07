using System.Data.Entity;
using YellowPages.Entities.Models;

namespace YellowPages.DataAccess.EntityFramework
{
    internal interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class ;
    }
}