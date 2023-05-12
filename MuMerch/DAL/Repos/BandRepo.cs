using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BandRepo : BaseRepo, IBaseRepo<Band, int, int, Band>
    {
        public List<Band> GetAll()
        {
            return mmContext.Bands.ToList();
        }

        public Band GetById(int id)
        {
            return mmContext.Bands.Find(id);
        }

        public int Insert(Band obj)
        {
            mmContext.Bands.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Band obj)
        {
            var data = mmContext.Bands.Find(obj.Id);
            data.Name = obj.Name;
            data.IsActive = obj.IsActive;
            data.UpdatedAt = obj.UpdatedAt;
            data.UpdatedBy = obj.UpdatedBy;
            return mmContext.SaveChanges();

        }
        public int Delete(Band band)
        {
            var data = mmContext.Bands.Find(band.Id);
            mmContext.Bands.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
