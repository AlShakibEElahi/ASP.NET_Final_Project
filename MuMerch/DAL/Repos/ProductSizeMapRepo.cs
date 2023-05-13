using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProductSizeMapRepo : BaseRepo, IBaseRepo<ProductSizeMap, int, int, ProductSizeMap>
    {

        public List<ProductSizeMap> GetAll()
        {
            return mmContext.ProductSizeMaps.ToList();
        }

        public ProductSizeMap GetById(int id)
        {
            return mmContext.ProductSizeMaps.Find(id);
        }

        public int Insert(ProductSizeMap obj)
        {
            mmContext.ProductSizeMaps.Add(obj);
            return mmContext.SaveChanges();
        }

        public int Update(ProductSizeMap obj)
        {
            var data = mmContext.ProductSizeMaps.Find(obj.Id);
           mmContext.Entry(data).CurrentValues.SetValues(data);

            return mmContext.SaveChanges();

        }
        public int Delete(ProductSizeMap grade)
        {
            var data = mmContext.ProductSizeMaps.Find(grade.Id);
            mmContext.ProductSizeMaps.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
