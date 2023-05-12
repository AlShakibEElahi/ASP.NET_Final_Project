using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SizeRepo : BaseRepo, IBaseRepo<Size, int, int, Size>
    {
        public int Delete(Size size)
        {
            var data = mmContext.Sizes.Find(size.Id);
            mmContext.Sizes.Remove(size);
            return mmContext.SaveChanges();
        }

        public List<Size> GetAll()
        {
            return mmContext.Sizes.ToList();
        }

        public Size GetById(int id)
        {
            var data = mmContext.Sizes.Find(id);
            return data;
        }

        public int Insert(Size obj)
        {
            mmContext.Sizes.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(Size obj)
        {
            var data = mmContext.Sizes.Find(obj.Id);
            mmContext.Entry(data).CurrentValues.SetValues(obj);
            return mmContext.SaveChanges();
        }
    }
}
