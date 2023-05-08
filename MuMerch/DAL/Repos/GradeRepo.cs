using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{

    internal class GradeRepo : BaseRepo, IBaseRepo<Grade, int, int, Grade>
    {
        public List<Grade> GetAll()
        {
            return mmContext.Grades.ToList();
        }

        public Grade GetById(int id)
        {
            return mmContext.Grades.Find(id);
        }

        public int Insert(Grade obj)
        {
            mmContext.Grades.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Grade obj)
        {
            var data = mmContext.Grades.Find(obj.Id);
            data.Name = obj.Name;
            data.IsActive = obj.IsActive;
            data.UpdatedAt = obj.UpdatedAt;
            data.UpdatedBy = obj.UpdatedBy;
            return mmContext.SaveChanges();

        }
        public int Delete(Grade grade)
        {
            var data = mmContext.Grades.Find(grade.Id);
            mmContext.Grades.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
