using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
    public class GradeDTO
    {
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
