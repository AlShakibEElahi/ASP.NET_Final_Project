using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : BaseRepo, IBaseRepo<Customer, int, int, Customer>
    {
        public List<Customer> GetAll()
        {
            return mmContext.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return mmContext.Customers.Find(id);
        }

        public int Insert(Customer cstmr)
        {
            mmContext.Customers.Add(cstmr);
            return mmContext.SaveChanges();
        }

        public int Update(Customer cstmr)
        {
            var data = mmContext.Customers.Find(cstmr.Id);
            data.Name = cstmr.Name;
            data.IsActive = cstmr.IsActive;
            data.UpdatedAt = cstmr.UpdatedAt;
            data.UpdatedBy = cstmr.UpdatedBy;
            return mmContext.SaveChanges();

        }
        public int Delete(Customer cstmr)
        {
            var data = mmContext.Customers.Find(cstmr.Id);
            mmContext.Customers.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}
