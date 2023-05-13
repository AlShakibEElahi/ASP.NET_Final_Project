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
    public class BandManagerService
    {
        public static List<BandManagerDTO> GetAll()
        {
            var data = DataAccess.BandManagerContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandManager, BandManagerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<BandManagerDTO>>(data);
            return mapped;
        }
        public static BandManagerDTO Get(int id)
        {
            var data = DataAccess.BandManagerContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandManager, BandManagerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BandManagerDTO>(data);
            return mapped;
        }
        public static int Add(BandManagerDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandManagerDTO, BandManager>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BandManager>(dto);
            return DataAccess.BandManagerContent().Insert(mapped);
        }
        public static int Delete(BandManagerDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandManagerDTO, BandManager>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BandManager>(dto);
            return DataAccess.BandManagerContent().Delete(mapped);
        }
        public static int Edit(BandManagerDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<BandManagerDTO, BandManager>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<BandManager>(dto);
            return DataAccess.BandManagerContent().Update(mapped);
        }
    }
}
