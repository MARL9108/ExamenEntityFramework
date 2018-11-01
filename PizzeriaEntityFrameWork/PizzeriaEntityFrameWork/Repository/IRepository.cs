﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaEntityFrameWork.Repository
{
    public interface IRepository<T>:IRepositoryAdd<T>,IRepositoryDelete<T>,IRepositoryUpdate<T> where T:class
    {
    }
    public interface IRepositoryAdd<T> where T:class
    {
        void Add(T entity);
    }
    public interface IRepositoryDelete<T> where T : class
    {
        void Delete(T entity);
    }
    public interface IRepositoryUpdate<T> where T : class
    {
        void Update(T entity);
    }
}