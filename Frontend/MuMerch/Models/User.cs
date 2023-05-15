using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        [Required]
        public string Password { get; set; }
        public string Image { get; set; }
        [Required]
        public string UserType { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        [Required]
        [StringLength(11)]
        public string PhoneNo { get; set; }
    }
}