using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ProductOrderMapDTO
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
    }
}
