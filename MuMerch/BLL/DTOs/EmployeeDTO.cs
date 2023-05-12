using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployeeDTO
    {
        public string EmployeeId { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; }
        public int GradeId { get; set; }
        public int DesignationId { get; set; }
        public int UnitId { get; set; }
        public int DepartmentId { get; set; }
        public int DivisionId { get; set; }
        public int LocationId { get; set; }
        [Required]
        [StringLength(17)]
        public string NidNo { get; set; }
        [StringLength(25)]
        public string BrnNo { get; set; }
        [StringLength(25)]
        public string PassportNo { get; set; }
        [StringLength(35)]
        public string TinNo { get; set; }
        [Required]
        [StringLength(150)]
        public string FathersName { get; set; }
        [Required]
        [StringLength(150)]
        public string MothersName { get; set; }
        [Required]
        [StringLength(250)]
        public string PresentAddress { get; set; }
        [Required]
        [StringLength(250)]
        public string PermanentAddress { get; set; }
        public string UserId { get; set; }
    }
}
