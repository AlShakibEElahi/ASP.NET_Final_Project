using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DesignationRepo : BaseRepo, IBaseRepo<Designation, int, int, Designation>
    {
        public int Delete(Designation unit)
        {
            var data = mmContext.Designations.Find(unit.Id);
            mmContext.Designations.Remove(unit);
            return mmContext.SaveChanges();
        }

        public List<Designation> GetAll()
        {
            return mmContext.Designations.ToList();
        }

        public Designation GetById(int id)
        {
            var data = mmContext.Designations.Find(id);
            return data;
        }

        public int Insert(Designation obj)
        {
            mmContext.Designations.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Designation obj)
        {
            var data = mmContext.Designations.Find(obj.Id);
            mmContext.Entry(data).CurrentValues.SetValues(obj);
            return mmContext.SaveChanges();
        }
    }
}
