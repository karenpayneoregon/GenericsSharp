using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindEntityFramework.Interfaces;

namespace NorthWindEntityFramework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private NorthContext _northContext = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            _northContext = new NorthContext();
            table = _northContext.Set<T>();
        }
        public GenericRepository(NorthContext context)
        {
            _northContext = context;
            table = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _northContext.Entry(obj).State = EntityState.Modified;
        }
        public void Save()
        {
            _northContext.SaveChanges();
        }

        IEnumerable<T> IGenericRepository<T>.GetAll()
        {
            return table.ToList();
        }

        T IGenericRepository<T>.GetById(object id)
        {
            var item = _northContext.Set<T>().Find(id);
            return item;
        }

        T IGenericRepository<T>.Insert(T obj)
        {
            return table.Add(obj);
        }

        void IGenericRepository<T>.Update(T obj)
        {
            table.Attach(obj);
            _northContext.Entry(obj).State = EntityState.Modified;
        }

        void IGenericRepository<T>.Delete(object id)
        {
            var item = _northContext.Set<T>().Find(id);
            table.Remove(item);
        }

        int IGenericRepository<T>.Save()
        {
            return _northContext.SaveChanges();
        }
    }

}
