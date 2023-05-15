using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class BandManager
    {
        [Key]
        [Required]
        public int BandManagerId { get; set; }
        [Required]
        [ForeignKey("Band")]
        public int BandId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual Band Band { get; set; }
        public virtual User User { get; set; }
    }
}
