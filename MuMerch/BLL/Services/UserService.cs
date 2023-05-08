using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static List<UserDTO> GetAll()
        {
            var data = DataAccess.UserContent().GetAll();
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, UserDTO>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;
        }
        public static UserDTO Get(string id)
        {
            var data = DataAccess.UserContent().GetById(id);
            return Convert(data);
        }
        public static int Add(UserDTO dto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
            });

            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User>(dto);
            return DataAccess.UserContent().Insert(mapped);
        }
        public static int Delete(UserDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.UserContent().Delete(data);
        }
        public static int Edit(UserDTO dto)
        {
            var data = Convert(dto);
            return DataAccess.UserContent().Update(data);
        }
        static List<UserDTO> Convert(List<User> user)
        {
            var data = new List<UserDTO>();
            foreach (User usr in user)
            {
                data.Add(Convert(usr));
            }
            return data;
        }

        static UserDTO Convert(User user)
        {
            return new UserDTO()
            {
                Id = user.Id,
                Name = user.Name,
                BloodGroup = user.BloodGroup,
                Password = user.Password,
                Image = user.Image,
                UserType = user.UserType,
                Email = user.Email,
                PhoneNo = user.PhoneNo
            };
        }
        static List<User> Convert(List<UserDTO> user)
        {
            var data = new List<User>();
            foreach (UserDTO usr in user)
            {
                data.Add(Convert(usr));
            }
            return data;
        }

        static User Convert(UserDTO user)
        {
            return new User()
            {
                Id = user.Id,
                Name = user.Name,
                BloodGroup = user.BloodGroup,
                Password = user.Password,
                Image = user.Image,
                UserType = user.UserType,
                Email = user.Email,
                PhoneNo = user.PhoneNo
            };
        }
    }
}
