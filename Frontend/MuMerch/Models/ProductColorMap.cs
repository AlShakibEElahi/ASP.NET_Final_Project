using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class ProductColorMap
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Color Color { get; set; }
    }
}