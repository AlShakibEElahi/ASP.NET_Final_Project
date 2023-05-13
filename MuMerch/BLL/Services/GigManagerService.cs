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
    public class GigManagerService
    {

        public static List<GigManagerDTO> GetAll()
        {
            var data = DataAccess.GigManagerContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigManager, GigManagerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<GigManagerDTO>>(data);
            return mapped;
        }
        public static GigManagerDTO Get(int id)
        {
            var data = DataAccess.GigManagerContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigManager, GigManagerDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GigManagerDTO>(data);
            return mapped;
        }
        public static int Add(GigManagerDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigManagerDTO, GigManager>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GigManager>(dto);
            return DataAccess.GigManagerContent().Insert(mapped);
        }
        public static int Delete(GigManagerDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigManagerDTO, GigManager>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GigManager>(dto);
            return DataAccess.GigManagerContent().Delete(mapped);
        }
        public static int Edit(GigManagerDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<GigManagerDTO, GigManager>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<GigManager>(dto);
            return DataAccess.GigManagerContent().Update(mapped);
        }
    }
}