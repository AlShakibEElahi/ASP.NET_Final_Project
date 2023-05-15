using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Gig
    {
        public int Id { get; set; }
        [Required]
        [StringLength(170)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("User")]
        public string UpdatedBy { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual User User { get; set; }
        public virtual Location Location { get; set; }
    }
}