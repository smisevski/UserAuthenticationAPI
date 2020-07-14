using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using UserAuthenticationAPI.Models;

namespace UserAuthenticationAPI.DataAccess.RepositoryBase
{
    public interface IRepositoryBase<T>
    {
        T GetById(Guid Id);
        IQueryable<T> GetAll();
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity, T inEntity); //LOL 
        void Remove(T entity);
        
    }
}