using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class LocationRepo : BaseRepo, IBaseRepo<Location, int, int, Location>
    {
        public List<Location> GetAll()
        {
            return mmContext.Locations.ToList();
        }

        public Location GetById(int id)
        {
            return mmContext.Locations.Find(id);
        }

        public int Insert(Location ln)
        {
            mmContext.Locations.Add(ln);
            return mmContext.SaveChanges();
        }

        public int Update(Location ln)
        {
            var data = mmContext.Locations.Find(ln);
            data.Id = ln.Id;
            data.Name = ln.Name;
            data.IsActive = ln.IsActive;
            data.UpdatedAt = ln.UpdatedAt;
            data.UpdatedBy = ln.UpdatedBy;
            return mmContext.SaveChanges();

        }
        public int Delete(Location location)
        {
            var data = mmContext.Locations.Find(location.Id);
            mmContext.Locations.Remove(location);
            return mmContext.SaveChanges();
        }
    }
}
