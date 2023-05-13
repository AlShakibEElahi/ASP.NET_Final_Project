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
    public class GigService
    {
        public static List<GigDTO> GetAll()
        {
            var data = DataAccess.GigContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Gig, GigDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<GigDTO>>(data);
            return mapped;
        }
        public static GigDTO Get(int id)
        {
            var data = DataAccess.GigContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Gig, GigDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GigDTO>(data);
            return mapped;
        }
        public static int Add(GigDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigDTO, Gig>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Gig>(dto);
            return DataAccess.GigContent().Insert(mapped);
        }
        public static int Delete(GigDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigDTO, Gig>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Gig>(dto);
            return DataAccess.GigContent().Delete(mapped);
        }
        public static int Edit(GigDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigDTO, Gig>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Gig>(dto);
            return DataAccess.GigContent().Update(mapped);
        }
    }
}
