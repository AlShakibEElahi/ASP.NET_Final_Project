using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductColorMapDTO
    {   
        public int ProductId { get; set; }
       
        public int ColorId { get; set; }
    }
}
