using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : BaseRepo, IBaseRepo<Employee, int, string, Employee>
    {
        public int Delete(Employee employee)
        {
            var data = mmContext.Employees.Find(employee.EmployeeId);
            mmContext.Employees.Remove(employee);
            return mmContext.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return mmContext.Employees.ToList();
        }

        public Employee GetById(string id)
        {
            var data = mmContext.Employees.Find(id);
            return data;
        }

        public int Insert(Employee obj)
        {
            mmContext.Employees.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Employee obj)
        {
            var data = mmContext.Employees.Find(obj.EmployeeId);
            mmContext.Entry(data).CurrentValues.SetValues(obj);
            return mmContext.SaveChanges();
        }
    }
}
