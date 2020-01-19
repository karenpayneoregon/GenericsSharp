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
        private IGenericRepository<Employee> repository = null;

        public EmployeesOperations()
        {
            repository = new GenericRepository<Employee>();
        }

        public EmployeesOperations(IGenericRepository<Employee> repository)
        {
            repository = repository;
        }

        public Employee Edit(int employeeIdentifier)
        {
            var model = repository.GetById(employeeIdentifier);

            return model;
        }
        public Employee Edit(Employee employee)
        {

            repository.Update(employee);
            repository.Save();

            return employee;
        }

        public Employee Add(Employee employee)
        {
            return repository.Insert(employee);
        }
        /// <summary>
        /// Uses IGenericRepository GetAll synchronously 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> GetEmployees()
        {
            return repository.GetAll();
        }
        /// <summary>
        /// Uses IGenericRepository GetAll asynchronously with a DTO
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EmployeeDto>> GetEmployeesAsync()
        {
            var iEnumerableResults = await Task.Run(() => repository.GetAll());

            return iEnumerableResults.Select(emp => new EmployeeDto()
            {
                Id = emp.EmployeeID,
                FullName = $"{emp.FirstName} {emp.LastName}"
            });
        }
        /// <summary>
        /// Remove single employee
        /// </summary>
        /// <param name="identifier">Existing employee identifier</param>
        /// <returns></returns>
        public bool Delete(int identifier)
        {
            if (repository.GetById(identifier) == null)
            {
                return false;
            }

            repository.Delete(identifier);
            repository.Save();

            return repository.GetById(identifier) == null;

        }

        public int Save()
        {
            return repository.Save();
        }
    }
}
