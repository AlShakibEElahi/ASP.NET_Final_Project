using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class GigDTO
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
        public string UpdatedBy { get; set; }
        public int LocationId { get; set; }
    }
}
