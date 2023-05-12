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
    public class EmployeeService
    {
        public static List<EmployeeDTO> GetAll()
        {
            var data = DataAccess.EmployeeContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Employee, EmployeeDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<EmployeeDTO>>(data);
            return mapped;
        }
        public static EmployeeDTO Get(string id)
        {
            var data = DataAccess.EmployeeContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Employee, EmployeeDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<EmployeeDTO>(data);
            return mapped;
        }
        public static int Add(EmployeeDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<EmployeeDTO, Employee>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Employee>(dto);
            return DataAccess.EmployeeContent().Insert(mapped);
        }
        public static int Delete(EmployeeDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<EmployeeDTO, Employee>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Employee>(dto);
            return DataAccess.EmployeeContent().Delete(mapped);
        }
        public static int Edit(EmployeeDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<EmployeeDTO, Employee>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Employee>(dto);
            return DataAccess.EmployeeContent().Update(mapped);
        }
    }
}
