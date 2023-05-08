using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Entities;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GradeService
    {
        public static List<GradeDTO> GetAll()
        {
            var data = DataAccess.GradeContent().GetAll();
            return Convert(data);
        }
        public static GradeDTO Get(int id)
        {
            var data = DataAccess.GradeContent().GetById(id);
            return Convert(data);
        }
        public static int Add(GradeDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.GradeContent().Insert(data);
        }
        public static int Delete(GradeDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.GradeContent().Delete(data);
        }
        public static int Edit(GradeDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.GradeContent().Update(data);
        }
        static List<Grade> Convert(List<GradeDTO> nwz)
        {
            var data = new List<Grade>();
            foreach (GradeDTO ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static Grade Convert(GradeDTO grade)
        {
            return new Grade()
            {
                Name = grade.Name,
                IsActive = grade.IsActive,
                UpdatedAt= grade.UpdatedAt,
                UpdatedBy= grade.UpdatedBy
            };
        }
        static List<GradeDTO> Convert(List<Grade> nwz)
        {
            var data = new List<GradeDTO>();
            foreach (Grade ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static GradeDTO Convert(Grade grade)
        {
            return new GradeDTO()
            {
                Name = grade.Name,
                IsActive = grade.IsActive,
                UpdatedAt= grade.UpdatedAt,
                UpdatedBy = grade.UpdatedBy
            };
        }
    }
}
