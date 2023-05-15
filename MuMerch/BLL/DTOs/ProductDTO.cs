using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductDTO
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
       
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public string Image { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal SellingPrice { get; set; }
        [Required]
        public decimal RevenuePercentage { get; set; }
        
        public int ProUnitId { get; set; }
        public int CategoryId { get; set; }
        public int BandId { get; set; }
        public int GigId { get; set; }
    }
}
