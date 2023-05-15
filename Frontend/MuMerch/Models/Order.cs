using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MuMerch.Models
{
    public class Order
    {
        public int Id { get; set; }
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