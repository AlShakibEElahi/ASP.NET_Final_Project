using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Login
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Password { get; set; }
    }
}