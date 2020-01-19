using System;
using System.Collections.Generic;

namespace NorthWindEntityFramework.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> SearchFor(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        TEntity Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(object id);
        int Save();
    }
}
