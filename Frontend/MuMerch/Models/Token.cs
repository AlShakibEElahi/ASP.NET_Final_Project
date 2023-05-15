using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Token
    {
        public string TokenKey { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}