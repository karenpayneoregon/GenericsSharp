using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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
        private DbSet<TEntity> _entity = null;

        public GenericRepository()
        {
            _dbContext = Activator.CreateInstance<TContext>();
            _entity = _dbContext.Set<TEntity>();
        }

        public TContext DbContext { get; set; }
        public GenericRepository(NorthContext context)
        {
            _dbContext = Activator.CreateInstance<TContext>();
            _dbContext.Configuration.LazyLoadingEnabled = true;
            _entity = context.Set<TEntity>();
        }

        public TContext Context => _dbContext;
        public IEnumerable<TEntity> GetAll()
        {
            return _entity.ToList();
        }
        public TEntity GetById(object id)
        {
            return _entity.Find(id);
        }
        public void Update(TEntity obj)
        {
            _entity.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.GetAll()
        {
            return _entity.ToList();
        }

        TEntity IGenericRepository<TEntity>.GetById(object id)
        {
            var item = _dbContext.Set<TEntity>().Find(id);
            return item;
        }

        TEntity IGenericRepository<TEntity>.Insert(TEntity obj)
        {
            return _entity.Add(obj);
        }

        void IGenericRepository<TEntity>.Update(TEntity obj)
        {
            _entity.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        void IGenericRepository<TEntity>.Delete(object id)
        {
            var item = _dbContext.Set<TEntity>().Find(id);
            _entity.Remove(item);
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
        public IEnumerable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).AsEnumerable();
        }

    }

}
