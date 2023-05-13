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
    public class LocationService
    {
        public static List<LocationDTO> GetAll()
        {
            var data = DataAccess.LocationContent().GetAll();
            return Convert(data);
        }
        public static LocationDTO Get(int id)
        {
            var data = DataAccess.LocationContent().GetById(id);
            return Convert(data);
        }
        public static int Add(LocationDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.LocationContent().Insert(data);
        }
        public static int Delete(LocationDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.LocationContent().Delete(data);
        }
        public static int Edit(LocationDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.LocationContent().Update(data);
        }
        static List<Location> Convert(List<LocationDTO> lnz)
        {
            var data = new List<Location>();
            foreach (LocationDTO ln in lnz)
            {
                data.Add(Convert(ln));
            }
            return data;
        }

        static Location Convert(LocationDTO location)
        {
            return new Location()
            {
                Id = location.Id,
                Name = location.Name,
                IsActive = location.IsActive,
                UpdatedAt = location.UpdatedAt,
                UpdatedBy = location.UpdatedBy
            };
        }
        static List<LocationDTO> Convert(List<Location> lnz)
        {
            var data = new List<LocationDTO>();
            foreach (Location ln in lnz)
            {
                data.Add(Convert(ln));
            }
            return data;
        }

        static LocationDTO Convert(Location location)
        {
            return new LocationDTO()
            {
                Id = location.Id,
                Name = location.Name,
                IsActive = location.IsActive,
                UpdatedAt = location.UpdatedAt,
                UpdatedBy = location.UpdatedBy
            };
        }
    }
}
