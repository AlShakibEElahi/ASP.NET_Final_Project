using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class GigManager
    {
        [Key]
        [Required]
        public int GigManagerId { get; set; }
        [ForeignKey("Gig")]

        public int GigId { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual Gig Gig { get; set; }
        public virtual User User { get; set; }
    }
}
