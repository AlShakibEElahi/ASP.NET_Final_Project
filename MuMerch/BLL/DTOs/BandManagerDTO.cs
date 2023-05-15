using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs
{
    public class BandManagerDTO
    {
        [Required]
        public int BandManagerId { get; set; }
        [Required]
        public int BandId { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
