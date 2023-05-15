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
        public int GigManagerId { get; set; }
        [Required]
        public int GigId { get; set; }
        [Required]
        public int? UserId { get; set; }
    }
}
