using System.Data.Entity;

namespace PizzeriaEntityFrameWork.Repository
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}