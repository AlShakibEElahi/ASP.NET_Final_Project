using BLL.DTOs;
using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CustomerService
    {
        public static List<CustomerDTO> GetAll()
        {
            var data = DataAccess.CustomerContent().GetAll();
            return Convert(data);
        }
        public static CustomerDTO Get(int id)
        {
            var data = DataAccess.CustomerContent().GetById(id);
            return Convert(data);
        }
        public static int Add(CustomerDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.CustomerContent().Insert(data);
        }
        public static int Delete(CustomerDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.CustomerContent().Delete(data);
        }
        public static int Edit(CustomerDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.CustomerContent().Update(data);
        }
        static List<Customer> Convert(List<CustomerDTO> cstmr)
        {
            var data = new List<Customer>();
            foreach (CustomerDTO cs in cstmr)
            {
                data.Add(Convert(cs));
            }
            return data;
        }

        static Customer Convert(CustomerDTO customer)
        {
            return new Customer()
            {
                Id = customer.Id,
                Name = customer.Name,
                Address = customer.Address,
                PhoneNo = customer.PhoneNo,
                Email = customer.Email,
                IsActive = customer.IsActive,
                UpdatedAt = customer.UpdatedAt,
                UpdatedBy = customer.UpdatedBy
            };
        }
        static List<CustomerDTO> Convert(List<Customer> cstmr)
        {
            var data = new List<CustomerDTO>();
            foreach (Customer cs in cstmr)
            {
                data.Add(Convert(cs));
            }
            return data;
        }

        static CustomerDTO Convert(Customer customer)
        {
            return new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Address = customer.Address,
                PhoneNo = customer.PhoneNo,
                Email = customer.Email,
                IsActive = customer.IsActive,
                UpdatedAt = customer.UpdatedAt,
                UpdatedBy = customer.UpdatedBy
            };
        }
    }
}
