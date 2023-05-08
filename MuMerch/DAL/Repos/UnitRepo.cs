using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UnitRepo : BaseRepo, IBaseRepo<Unit, int, int, Unit>
    {
        public int Delete(Unit unit)
        {
            var data = mmContext.Units.Find(unit.Id);
            mmContext.Units.Remove(unit);
            return mmContext.SaveChanges();
        }

        public List<Unit> GetAll()
        {
            return mmContext.Units.ToList();
        }

        public Unit GetById(int id)
        {
            var data = mmContext.Units.Find(id);
            return data;
        }

        public int Insert(Unit obj)
        {
            mmContext.Units.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Unit obj)
        {
            var data = mmContext.Units.Find(obj.Id);
            mmContext.Entry(data).CurrentValues.SetValues(obj);
            return mmContext.SaveChanges();

        }
    }
}
