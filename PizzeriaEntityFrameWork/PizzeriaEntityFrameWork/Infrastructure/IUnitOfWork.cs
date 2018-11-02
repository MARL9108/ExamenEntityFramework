using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Models
{
    public interface IUnitOfWork<T> where T:class
    {
        IDbSet<T> Pizza { get; set; }
        void Commit();
        void Rollback();
        /*int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();*/

    }
}
