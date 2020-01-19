using System.Collections.Generic;

namespace NorthWindEntityFramework.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        T Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        int Save();
    }
}
