using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BandManagerRepo : BaseRepo, IBaseRepo<BandManager, int, int, BandManager>
    {
        public List<BandManager> GetAll()
        {
            return mmContext.BandManagers.ToList();
        }

        public BandManager GetById(int id)
        {
            return mmContext.BandManagers.Find(id);
        }

        public int Insert(BandManager bm)
        {
            mmContext.BandManagers.Add(bm);
            return mmContext.SaveChanges();
        }

        public int Update(BandManager bm)
        {
            var data = mmContext.BandManagers.Find(bm);
            data.BandManagerId = bm.BandManagerId;
            data.BandId = bm.BandId;
            data.UserId = bm.UserId;
            return mmContext.SaveChanges();

        }
        public int Delete(BandManager bandManager)
        {
            var data = mmContext.BandManagers.Find(bandManager.BandManagerId);
            mmContext.BandManagers.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
