using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ColorRepo : BaseRepo, IBaseRepo<Color, int, int, Color>
    {
        public List<Color> GetAll()
        {
            return mmContext.Colors.ToList();
        }

        public Color GetById(int id)
        {
            return mmContext.Colors.Find(id);
        }

        public int Insert(Color color)
        {
            mmContext.Colors.Add(color);
            return mmContext.SaveChanges();
        }

        public int Update(Color color)
        {
            var data = mmContext.Colors.Find(color.Id);
            data.Name = color.Name;
            data.ColorCode = color.ColorCode;
            data.IsActive = color.IsActive;
            data.UpdatedAt = color.UpdatedAt;
            data.UpdatedBy = color.UpdatedBy;
            return mmContext.SaveChanges();
        }

        public int Delete(Color color)
        {
            var data = mmContext.Colors.Find(color.Id);
            mmContext.Colors.Remove(data);
            return mmContext.SaveChanges();
        }
    }
}

