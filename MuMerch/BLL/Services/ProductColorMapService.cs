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
    public class ProductColorMapService
    {
        public static List<ProductColorMapDTO> GetAll()
        {
            var data = DataAccess.ProductColorMapContent().GetAll();
            return Convert(data);
        }
        public static ProductColorMapDTO Get(int id)
        {
            var data = DataAccess.ProductColorMapContent().GetById(id);
            return Convert(data);
        }
        public static int Add(ProductColorMapDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.ProductColorMapContent().Insert(data);
        }
        public static int Delete(ProductColorMapDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.ProductColorMapContent().Delete(data);
        }
        public static int Edit(ProductColorMapDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.ProductColorMapContent().Update(data);
        }
        static List<ProductColorMap> Convert(List<ProductColorMapDTO> nwz)
        {
            var data = new List<ProductColorMap>();
            foreach (ProductColorMapDTO ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static ProductColorMap Convert(ProductColorMapDTO product)
        {
            return new ProductColorMap()
            { 
                ProductId= product.ProductId,
                ColorId = product.ColorId
            };
        }
        static List<ProductColorMapDTO> Convert(List<ProductColorMap> nwz)
        {
            var data = new List<ProductColorMapDTO>();
            foreach (ProductColorMap ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static ProductColorMapDTO Convert(ProductColorMap product)
        {
            return new ProductColorMapDTO()
            {
                ProductId = product.ProductId,
                ColorId = product.ColorId

            };
        }
    }
}
