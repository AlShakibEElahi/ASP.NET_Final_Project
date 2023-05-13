using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class GigManagerRepo : BaseRepo, IBaseRepo<GigManager, int, int, GigManager>
    {
        public List<GigManager> GetAll()
        {
            return mmContext.GigManagers.ToList();
        }

        public GigManager GetById(int id)
        {
            return mmContext.GigManagers.Find(id);
        }

        public int Insert(GigManager gm)
        {
            mmContext.GigManagers.Add(gm);
            return mmContext.SaveChanges();
        }

        public int Update(GigManager gm)
        {
            var data = mmContext.GigManagers.Find(gm);
            data.GigManagerId = gm.GigManagerId;
            data.GigId = gm.GigId;
            data.UserId = gm.UserId;
            return mmContext.SaveChanges();

        }
        public int Delete(GigManager gigManager)
        {
            var data = mmContext.GigManagers.Find(gigManager.GigManagerId);
            mmContext.GigManagers.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
