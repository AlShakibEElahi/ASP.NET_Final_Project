using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int OrderedQuantity { get; set; }
        public int CustomerId { get; set; }
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
