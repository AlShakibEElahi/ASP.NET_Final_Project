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
    public class BandService
    {
        public static List<BandDTO> GetAll()
        {
            var data = DataAccess.BandContent().GetAll();
            return Convert(data);
        }
        public static BandDTO Get(int id)
        {
            var data = DataAccess.BandContent().GetById(id);
            return Convert(data);
        }
        public static int Add(BandDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.BandContent().Insert(data);
        }
        public static int Delete(BandDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.BandContent().Delete(data);
        }
        public static int Edit(BandDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.BandContent().Update(data);
        }
        static List<Band> Convert(List<BandDTO> nwz)
        {
            var data = new List<Band>();
            foreach (BandDTO ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static Band Convert(BandDTO band)
        {
            return new Band()
            {
                Name = band.Name,
                Image= band.Image,
                OnboardDate= band.OnboardDate,
                IsActive = band.IsActive,
                UpdatedAt = band.UpdatedAt,
                UpdatedBy = band.UpdatedBy
            };
        }
        static List<BandDTO> Convert(List<Band> nwz)
        {
            var data = new List<BandDTO>();
            foreach (Band ns in nwz)
            {
                data.Add(Convert(ns));
            }
            return data;
        }

        static BandDTO Convert(Band band)
        {
            return new BandDTO()
            {
                Name = band.Name,
                Image = band.Image,
                OnboardDate = band.OnboardDate,
                IsActive = band.IsActive,
                UpdatedAt = band.UpdatedAt,
                UpdatedBy = band.UpdatedBy
            };
        }
    }
}

