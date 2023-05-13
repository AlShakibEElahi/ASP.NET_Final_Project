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
    public class DesignationService
    {
        public static List<DesignationDTO> GetAll()
        {
            var data = DataAccess.DesignationContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Designation, DesignationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DesignationDTO>>(data);
            return mapped;
        }
        public static DesignationDTO Get(int id)
        {
            var data = DataAccess.DesignationContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Designation, DesignationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DesignationDTO>(data);
            return mapped;
        }
        public static int Add(DesignationDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DesignationDTO, Designation>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Designation>(dto);
            return DataAccess.DesignationContent().Insert(mapped);
        }
        public static int Delete(DesignationDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DesignationDTO, Designation>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Designation>(dto);
            return DataAccess.DesignationContent().Delete(mapped);
        }
        public static int Edit(DesignationDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DesignationDTO, Designation>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Designation>(dto);
            return DataAccess.DesignationContent().Update(mapped);
        }
    }
}
