using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Address { get; set; }
        [Index("UniquePhoneNo", 1, IsUnique = true)]
        [StringLength(11)]
        public string PhoneNo { get; set; }
        [Index("UniqueEmail", 2, IsUnique = true)]
        [StringLength(70)]
        public string Email { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("User")]
        public string UpdatedBy { get; set; }
        public virtual User User { get; set; }
    }
}
