using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NorthWindEntityFramework.Interfaces;
using NorthWindEntityFramework.Repository;

namespace NorthWindEntityFramework
{
    /// <summary>
    /// Common customer operations
    /// </summary>
    /// <remarks>
    /// Note that cascading rules must be set properly on
    /// related tables.
    /// </remarks>
    public class CustomersOperations
    {
        private IGenericRepository<Customer> _repository = null;
        private readonly NorthContext _northContext = new NorthContext();
        public CustomersOperations()
        {
            _repository = new GenericRepository<Customer, NorthContext>();
        }

        public CustomersOperations(IGenericRepository<Customer> repository)
        {
            _repository = repository;
        }
        public Customer Edit(int customerIdentifier)
        {
            var item = _repository.GetById(customerIdentifier);

            return item;
        }
        public Customer Edit(Customer customer)
        {

            _repository.Update(customer);
            _repository.Save();

            return customer;
        }

        /// <summary>
        /// Add a new employee
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public Customer Add(Customer customer)
        {
            return _repository.Insert(customer);
        }
        /// <summary>
        /// Uses IGenericRepository GetAll synchronously 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Customer> GetCustomer()
        {
            return _repository.GetAll();
        }
        /// <summary>
        /// Uses IGenericRepository GetAll asynchronously with a DTO
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<CustomerDto>> GetEmployeesAsync()
        {
            var iEnumerableResults = await Task.Run(() => _repository.GetAll());

            return iEnumerableResults.Select(customer => new CustomerDto()
            {
                CustomerIdentifier = customer.CustomerIdentifier,
                ContactId = customer.ContactId,
                CompanyName = customer.CompanyName,
                ContactTypeIdentifier = customer.ContactTypeIdentifier,
                CountryIdentifier = customer.CountryIdentifier
            });
        }

        /// <summary>
        /// Remove single customer
        /// </summary>
        /// <param name="identifier">Existing employee identifier</param>
        /// <returns></returns>
        public bool Delete(int identifier)
        {
            if (_repository.GetById(identifier) == null)
            {
                return false;
            }

            _repository.Delete(identifier);
            _repository.Save();

            return _repository.GetById(identifier) == null;

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
