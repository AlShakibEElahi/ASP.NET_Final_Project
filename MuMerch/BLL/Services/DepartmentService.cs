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
    public class DepartmentService
    {
        public static List<DepartmentDTO> GetAll()
        {
            var data = DataAccess.DepartmentContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Department, DepartmentDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DepartmentDTO>>(data);
            return mapped;
        }
        public static DepartmentDTO Get(int id)
        {
            var data = DataAccess.DepartmentContent().GetById(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Department, DepartmentDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DepartmentDTO>(data);
            return mapped;
        }
        public static int Add(DepartmentDTO dto)
        {
            var data = new Department()
            {
                Name = dto.Name,
                IsActive = dto.IsActive,
                UpdatedAt = dto.UpdatedAt,
                UpdatedBy = dto.UpdatedBy,
            };
            return DataAccess.DepartmentContent().Insert(data);
        }
        public static int Delete(DepartmentDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DepartmentDTO, Department>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Department>(dto);
            return DataAccess.DepartmentContent().Delete(mapped);
        }
        public static int Edit(DepartmentDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DepartmentDTO, Department>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Department>(dto);
            return DataAccess.DepartmentContent().Update(mapped);
        }
    }
}
