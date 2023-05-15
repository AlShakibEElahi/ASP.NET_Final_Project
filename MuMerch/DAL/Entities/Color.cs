using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Color
    {
        [Key]
        [Required]
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
