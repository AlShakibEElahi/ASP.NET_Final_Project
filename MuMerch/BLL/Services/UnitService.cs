using BLL.DTOs;
using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services
{
    public class UnitService
    {
        public static List<UnitDTO> GetAll()
        {
            var data = DataAccess.UnitContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Unit, UnitDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UnitDTO>>(data);
            return mapped;
        }
        public static UnitDTO Get(int id)
        {
            var data = DataAccess.UnitContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Unit, UnitDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UnitDTO>(data);
            return mapped;
        }
        public static int Add(UnitDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UnitDTO, Unit>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Unit>(dto);
            return DataAccess.UnitContent().Insert(mapped);
        }
        public static int Delete(UnitDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UnitDTO, Unit>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Unit>(dto);
            return DataAccess.UnitContent().Delete(mapped);
        }
        public static int Edit(UnitDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UnitDTO, Unit>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Unit>(dto);
            return DataAccess.UnitContent().Update(mapped);
        }
    }
}
