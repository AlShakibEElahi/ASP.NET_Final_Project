using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductColorMapRepo : BaseRepo, IBaseRepo<ProductColorMap, int, int, ProductColorMap>
    {
        public List<ProductColorMap> GetAll()
        {
            return mmContext.ProductColorMaps.ToList();
        }

        public ProductColorMap GetById(int id)
        {
            return mmContext.ProductColorMaps.Find(id);
        }

        public int Insert(ProductColorMap obj)
        {
            mmContext.ProductColorMaps.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(ProductColorMap obj)
        {
            var data = mmContext.ProductColorMaps.Find(obj.Id);
            data.ProductId = obj.ProductId;
            data.ColorId= obj.ColorId;
            return mmContext.SaveChanges();

        }
        public int Delete(ProductColorMap grade)
        {
            var data = mmContext.ProductColorMaps.Find(grade.Id);
            mmContext.ProductColorMaps.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
