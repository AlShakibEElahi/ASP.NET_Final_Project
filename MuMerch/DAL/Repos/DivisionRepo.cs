using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DivisionRepo: BaseRepo, IBaseRepo<Division, int, int, Division>
    {
        public int Delete(Division unit)
        {
            var data = mmContext.Divisions.Find(unit.Id);
            mmContext.Divisions.Remove(unit);
            return mmContext.SaveChanges();
        }

        public List<Division> GetAll()
        {
            return mmContext.Divisions.ToList();
        }

        public Division GetById(int id)
        {
            var data = mmContext.Divisions.Find(id);
            return data;
        }

        public int Insert(Division obj)
        {
            mmContext.Divisions.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Division obj)
        {
            var data = mmContext.Divisions.Find(obj.Id);
            mmContext.Entry(data).CurrentValues.SetValues(obj);
            return mmContext.SaveChanges();
        }
    }
}
