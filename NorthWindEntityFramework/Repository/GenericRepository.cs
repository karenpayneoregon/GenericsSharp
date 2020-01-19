using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindEntityFramework.Interfaces;

namespace NorthWindEntityFramework.Repository
{
    public class GenericRepository<TEntity, TContext> : IGenericRepository<TEntity> 
        where TEntity : class 
        where TContext : DbContext
    {
        private TContext _dbContext = null;
        private DbSet<TEntity> table = null;

        public GenericRepository()
        {
            _dbContext = Activator.CreateInstance<TContext>();
            table = _dbContext.Set<TEntity>();

        }
        public GenericRepository(NorthContext context)
        {
            _dbContext = Activator.CreateInstance<TContext>();
            table = context.Set<TEntity>();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return table.ToList();
        }
        public TEntity GetById(object id)
        {
            return table.Find(id);
        }
        public void Update(TEntity obj)
        {
            table.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.GetAll()
        {
            return table.ToList();
        }

        TEntity IGenericRepository<TEntity>.GetById(object id)
        {
            var item = _dbContext.Set<TEntity>().Find(id);
            return item;
        }

        TEntity IGenericRepository<TEntity>.Insert(TEntity obj)
        {
            return table.Add(obj);
        }

        void IGenericRepository<TEntity>.Update(TEntity obj)
        {
            table.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        void IGenericRepository<TEntity>.Delete(object id)
        {
            var item = _dbContext.Set<TEntity>().Find(id);
            table.Remove(item);
        }

        int IGenericRepository<TEntity>.Save()
        {
            return _dbContext.SaveChanges();
        }

        /// <summary>
        /// Returns any items of TEntity matching criteria of the Predicate in pPredicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> SearchFor(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).AsEnumerable();
        }

    }

}
