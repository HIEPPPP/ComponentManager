using ComponentManager.Data;
using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ComponentContext context;

        public EmployeeRepository(ComponentContext context)
        {
            this.context = context;
        }

        public Employee Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            var existEmployee = context.Employees.FirstOrDefault(e => e.Id == id);
            if (existEmployee == null) return null;
            context.Employees.Remove(existEmployee);
            context.SaveChanges();
            return existEmployee;
        }

        public List<Employee> GetAll()
        {
            return context.Employees.AsNoTracking().ToList();
        }

        public Employee GetById(int id)
        {
            var existEmployee = context.Employees.FirstOrDefault(e => e.Id == id);
            if (existEmployee == null) return null;
            return existEmployee;
        }

        public Employee Update(int id, Employee employee)
        {
            var existEmployee = context.Employees.FirstOrDefault(e => e.Id == id);
            if (existEmployee == null) return null;
            existEmployee.MaNV = employee.MaNV;
            existEmployee.ChucVu = employee.ChucVu;
            existEmployee.PhoneNumber = employee.PhoneNumber;   
            existEmployee.Birthday = employee.Birthday; 
            existEmployee.FullName = employee.FullName;
            existEmployee.Department = employee.Department;
            existEmployee.Image = employee.Image;
            context.SaveChanges();
            return existEmployee;
        }
    }
}
