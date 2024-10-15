using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetById(int id);   
        Employee Update(int id, Employee employee);
        Employee Delete(int id);    
        Employee Create(Employee employee);
    }
}
