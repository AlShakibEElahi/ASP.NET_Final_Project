using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DepartmentRepo : BaseRepo, IBaseRepo<Department, int, int, Department>
    {
        public List<Department> GetAll()
        {
            return mmContext.Departments.ToList();
        }

        public Department GetById(int id)
        {
            return mmContext.Departments.Find(id);
        }

        public int Insert(Department dpt)
        {
            mmContext.Departments.Add(dpt);
            return mmContext.SaveChanges();
        }

        public int Update(Department dpt)
        {
            var data = mmContext.Departments.Find(dpt.Id);
            data.Name = dpt.Name;
            data.IsActive = dpt.IsActive;
            data.UpdatedAt = dpt.UpdatedAt;
            data.UpdatedBy = dpt.UpdatedBy;
            return mmContext.SaveChanges();
        }
        public int Delete(Department dpt)
        {
            var data = mmContext.Departments.Find(dpt.Id);
            mmContext.Departments.Remove(data);
            return mmContext.SaveChanges();
        }
    
}
}
