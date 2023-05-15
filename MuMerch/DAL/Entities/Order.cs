using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int OrderedQuantity { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("User")]
        public string UpdatedBy { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual User User { get; set; }
    }
}
