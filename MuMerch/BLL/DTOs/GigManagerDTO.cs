using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class GigManagerDTO
    {
        [Required]
        [StringLength(7)]
        public string GigManagerId { get; set; }
        [Required]
        public int GigId { get; set; }
        [Required]
        public int? UserId { get; set; }
    }
}
