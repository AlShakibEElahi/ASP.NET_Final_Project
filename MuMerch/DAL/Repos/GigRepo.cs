using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GigRepo : BaseRepo, IBaseRepo<Gig, int, int, Gig>
    {
        public int Delete(Gig unit)
        {
            var data = mmContext.Gigs.Find(unit.Id);
            mmContext.Gigs.Remove(unit);
            return mmContext.SaveChanges();
        }

        public List<Gig> GetAll()
        {
            return mmContext.Gigs.ToList();
        }

        public Gig GetById(int id)
        {
            var data = mmContext.Gigs.Find(id);
            return data;
        }

        public int Insert(Gig obj)
        {
            mmContext.Gigs.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Gig obj)
        {
            var data = mmContext.Gigs.Find(obj.Id);
            mmContext.Entry(data).CurrentValues.SetValues(obj);
            return mmContext.SaveChanges();
        }
    }
}
