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
    public class DivisionService
    {
        public static List<DivisionDTO> GetAll()
        {
            var data = DataAccess.DivisionContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Division, DivisionDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DivisionDTO>>(data);
            return mapped;
        }
        public static DivisionDTO Get(int id)
        {
            var data = DataAccess.DivisionContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Division, DivisionDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DivisionDTO>(data);
            return mapped;
        }
        public static int Add(DivisionDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DivisionDTO, Division>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Division>(dto);
            return DataAccess.DivisionContent().Insert(mapped);
        }
        public static int Delete(DivisionDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DivisionDTO, Division>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Division>(dto);
            return DataAccess.DivisionContent().Delete(mapped);
        }
        public static int Edit(DivisionDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DivisionDTO, Division>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Division>(dto);
            return DataAccess.DivisionContent().Update(mapped);
        }
    }
}
