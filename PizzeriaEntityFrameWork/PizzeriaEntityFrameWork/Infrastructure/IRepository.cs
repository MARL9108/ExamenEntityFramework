using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Repository
{
    public interface IRepository<T>:IRepositoryAdd<T>,IRepositoryGetAll<T> where T:class
    {
    }

    public interface IRepositoryGetAll<T> where T : class
    {
        void GetAll(T entity);
    }

    public interface IRepositoryAdd<T> where T:class
    {
        void Add(T entity);
    }
}
