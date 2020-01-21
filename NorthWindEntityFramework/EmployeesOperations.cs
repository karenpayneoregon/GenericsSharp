using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NorthWindEntityFramework.Interfaces;
using NorthWindEntityFramework.Repository;

namespace NorthWindEntityFramework
{
    /// <summary>
    /// Common operations
    /// </summary>
    /// <remarks>
    /// This version creates an instance of NorthContext which
    /// will change in the next part of the series.
    /// 
    /// Note that cascading rules must be set properly on
    /// related tables.
    /// </remarks>
    public class EmployeesOperations<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> _repository = null;
        private readonly NorthContext _northContext = new NorthContext();

        public EmployeesOperations()
        {
            _repository = new GenericRepository<TEntity, NorthContext>();            
        }

        public EmployeesOperations(IGenericRepository<TEntity> repository)
        {
            _repository = (IGenericRepository<TEntity>) Convert.ChangeType(repository, typeof(TEntity));
        }

        public TEntity Edit(int employeeIdentifier)
        {

            TEntity entity = _repository.GetById(employeeIdentifier);
            return entity;

        }
        public TEntity Edit(TEntity entity)
        {

            _repository.Update(entity);
            _repository.Save();

            return entity;

        }
        /// <summary>
        /// Add a new employee
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity Add(TEntity entity)
        {
            return _repository.Insert(entity);
        }
        /// <summary>
        /// Uses IGenericRepository GetAll synchronously 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetEmployees()
        {
            return _repository.GetAll();
        }
        /// <summary>
        /// Uses IGenericRepository GetAll asynchronously
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> GetEmployeesAsync()
        {
            IEnumerable<TEntity> iEnumerableResults = await Task.Run(() => _repository.GetAll());
            return iEnumerableResults;
        }
        /// <summary>
        /// Remove single employee
        /// </summary>
        /// <param name="identifier">Existing employee identifier</param>
        /// <returns></returns>
        public bool Delete(int identifier)
        {
            if (_repository.GetById(identifier) == null)
            {
                return false;
            }

            /*
             * We do not want to remove orders so if there are orders
             * stop.
             *
             * Note we have a private instance of NorthContext, next part
             * of this article this code will change to better work with it.
             * For now this is simply educational
             */
            Employee employee = ((NorthContext)_repository.Context).
                Employees.Include(emp => emp.Orders).FirstOrDefault(x => x.EmployeeID == identifier);

            if (employee.Orders != null && employee.Orders.Count >0)
            {
                return false;
            }

            _repository.Delete(identifier);

            try
            {
                _repository.Save();
                return _repository.GetById(identifier) == null;
            }
            catch (Exception ex)
            {

                /*
                 * In this case the cause is the record has a dependency
                 * on one or more orders.
                 */

                return false;
            }

        }
        /// <summary>
        /// Perform a search
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<Employee> SearchFor(Expression<Func<Employee, bool>> predicate)
        {
            return _northContext.Set<Employee>().Where(predicate).AsEnumerable();
        }

        /// <summary>
        /// Save changes 
        /// </summary>
        /// <returns>Count of entities saved</returns>
        public int Save()
        {
            return _repository.Save();
        }
    }
}
