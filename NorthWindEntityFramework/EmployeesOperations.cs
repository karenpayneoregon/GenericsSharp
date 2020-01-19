using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindEntityFramework.Interfaces;
using NorthWindEntityFramework.Repository;

namespace NorthWindEntityFramework
{
    public class EmployeesOperations
    {
        private IGenericRepository<Employee> _repository = null;

        public EmployeesOperations()
        {
            _repository = new GenericRepository<Employee, NorthContext>();
        }

        public EmployeesOperations(IGenericRepository<Employee> repository)
        {
            _repository = repository;
        }

        public Employee Edit(int employeeIdentifier)
        {
            var model = _repository.GetById(employeeIdentifier);

            return model;
        }
        public Employee Edit(Employee employee)
        {

            _repository.Update(employee);
            _repository.Save();

            return employee;
        }
        /// <summary>
        /// Add a new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee Add(Employee employee)
        {
            return _repository.Insert(employee);
        }
        /// <summary>
        /// Uses IGenericRepository GetAll synchronously 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetEmployees()
        {
            return _repository.GetAll();
        }
        /// <summary>
        /// Uses IGenericRepository GetAll asynchronously with a DTO
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var iEnumerableResults = await Task.Run(() => _repository.GetAll());

            return iEnumerableResults.Select(emp => new EmployeeDto()
            {
                Id = emp.EmployeeID,
                FirstName = emp.FirstName,
                LastName = emp.LastName
            });
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

            _repository.Delete(identifier);
            _repository.Save();

            return _repository.GetById(identifier) == null;

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
