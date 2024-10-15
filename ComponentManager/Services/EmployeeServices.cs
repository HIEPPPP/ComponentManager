using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class EmployeeServices
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeServices(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public List<Employee> GetListEmployee()
        {
            return employeeRepository.GetAll();
        }

        public Employee CreateEmployee(Employee employee)
        {
            return employeeRepository.Create(employee);
        }

        public Employee GetEmployeeById(int id) 
        {
            return employeeRepository.GetById(id);
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            return employeeRepository.Update(id, employee);
        }

        public Employee DeleteEmployee(int id) 
        {
            return employeeRepository.Delete(id);   
        }
    }
}
