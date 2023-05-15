using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class BandManager
    {
        public int BandManagerId { get; set; }
        [Required]
        [ForeignKey("Band")]
        public int BandId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual Band Band { get; set; }
        public virtual User User { get; set; }
    }
}