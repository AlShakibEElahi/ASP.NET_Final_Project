using AutoMapper;
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
    public class ProductSizeMapService
    {
        public static List<ProductSizeMapDTO> GetAll()
        {
            var data = DataAccess.ProductSizeMapContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductSizeMap, ProductSizeMapDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductSizeMapDTO>>(data);
            return mapped;
        }
        public static ProductSizeMapDTO Get(int id)
        {
            var data = DataAccess.ProductSizeMapContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductSizeMap, ProductSizeMapDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductSizeMapDTO>(data);
            return mapped;
        }
        public static int Add(ProductSizeMapDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductSizeMapDTO, ProductSizeMap>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductSizeMap>(dto);
            return DataAccess.ProductSizeMapContent().Insert(mapped);
        }
        public static int Delete(ProductSizeMapDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductSizeMapDTO, ProductSizeMap>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductSizeMap>(dto);
            return DataAccess.ProductSizeMapContent().Delete(mapped);
        }
        public static int Edit(ProductSizeMapDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<ProductSizeMapDTO, ProductSizeMap>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductSizeMap>(dto);
            return DataAccess.ProductSizeMapContent().Update(mapped);
        }
    }
}
