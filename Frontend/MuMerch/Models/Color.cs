using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Color
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [Required]
        [StringLength(9)]
        public string ColorCode { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("User")]
        public string UpdatedBy { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ProductColorMap> ProductColorMaps { get; set; }
        public Color()
        {
            ProductColorMaps = new List<ProductColorMap>();
        }
    }
}