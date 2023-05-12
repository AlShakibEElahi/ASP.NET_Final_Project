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
    public class ProductOrderMapService
    {
        public static List<ProductOrderMapDTO> GetAll()
        {
            var data = DataAccess.ProductOrderMapContent().GetAll();
            return Convert(data);
        }
        public static ProductOrderMapDTO Get(int id)
        {
            var data = DataAccess.ProductOrderMapContent().GetById(id);
            return Convert(data);
        }
        public static int Add(ProductOrderMapDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.ProductOrderMapContent().Insert(data);
        }
        public static int Delete(ProductOrderMapDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.ProductOrderMapContent().Delete(data);
        }
        public static int Edit(ProductOrderMapDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.ProductOrderMapContent().Update(data);
        }
        static List<ProductOrderMap> Convert(List<ProductOrderMapDTO> nwz)
        {
            var data = new List<ProductOrderMap>();
            foreach (ProductOrderMapDTO ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static ProductOrderMap Convert(ProductOrderMapDTO product)
        {
            return new ProductOrderMap()
            {
                ProductId = product.ProductId,
                OrderId = product.OrderId
            };
        }
        static List<ProductOrderMapDTO> Convert(List<ProductOrderMap> nwz)
        {
            var data = new List<ProductOrderMapDTO>();
            foreach (ProductOrderMap ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static ProductOrderMapDTO Convert(ProductOrderMap product)
        {
            return new ProductOrderMapDTO()
            {
                ProductId = product.ProductId,
                OrderId = product.OrderId

            };
        }
    }
}
