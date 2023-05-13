using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : BaseRepo, IBaseRepo<Order, int, int, Order>
    {
        public List<Order> GetAll()
        {
            return mmContext.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return mmContext.Orders.Find(id);
        }

        public int Insert(Order od)
        {
            mmContext.Orders.Add(od);
            return mmContext.SaveChanges();
        }

        public int Update(Order od)
        {
            var data = mmContext.Orders.Find(od.Id);
            data.Id = od.Id;
            data.Date = od.Date;
            data.CustomerId = od.CustomerId;
            data.UpdatedBy = od.UpdatedBy;
            data.UpdatedAt = od.UpdatedAt;
            return mmContext.SaveChanges();

        }
        public int Delete(Order order)
        {
            var data = mmContext.Orders.Find(order.Id);
            mmContext.Orders.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
