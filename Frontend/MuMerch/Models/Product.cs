using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [ForeignKey("User")]
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public string Image { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal BuyingPrice { get; set; }
        [Required]
        public decimal SellingPrice { get; set; }
        [Required]
        public decimal RevenuePercentage { get; set; }
        [ForeignKey("ProductUnit")]
        public int ProUnitId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Band")]
        public int BandId { get; set; }
        [ForeignKey("Gig")]
        public int GigId { get; set; }
        public virtual User User { get; set; }
        public virtual ProductUnit ProductUnit { get; set; }
        public virtual Category Category { get; set; }
        public virtual Band Band { get; set; }
        public virtual Gig Gig { get; set; }

        public virtual ICollection<ProductColorMap> ProductColorMaps { get; set; }
        public virtual ICollection<ProductSizeMap> ProductSizeMaps { get; set; }
        public virtual ICollection<ProductOrderMap> ProductOrderMaps { get; set; }
        public Product()
        {
            ProductColorMaps = new List<ProductColorMap>();
            ProductSizeMaps = new List<ProductSizeMap>();
            ProductOrderMaps = new List<ProductOrderMap>();
        }
    }
}