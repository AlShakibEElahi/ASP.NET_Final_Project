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
    public class BandService
    {
        public static List<BandDTO> GetAll()
        {
            var data = DataAccess.BandContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Band, BandDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<BandDTO>>(data);
            return mapped;
        }
        public static BandDTO Get(int id)
        {
            var data = DataAccess.BandContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Band, BandDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BandDTO>(data);
            return mapped;
        }
        public static int Add(BandDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandDTO, Band>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Band>(dto);
            return DataAccess.BandContent().Insert(mapped);
        }
        public static int Delete(BandDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandDTO, Band>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Band>(dto);
            return DataAccess.BandContent().Delete(mapped);
        }
        public static int Edit(BandDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandDTO, Band>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Band>(dto);
            return DataAccess.BandContent().Update(mapped);
        }
    }
}

