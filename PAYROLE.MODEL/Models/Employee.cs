using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class Employee
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string FirsName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }

        //Employee
        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
        public int? EmploymentTypeId { get; set; }
        [ForeignKey("EmploymentTypeId")]
        public virtual EmploymentType EmploymentType { get; set; }
        public int? EmploymentStatusId { get; set; }
        [ForeignKey("EmploymentStatusId")]
        public virtual EmploymentStatus EmploymentStatus { get; set; }
        public DateTime DateHired { get; set; }

        //Philippine Government Mandatories
        public string SssNo { get; set; }
        public string PagibigNo { get; set; }
        public string PhilhealthNo { get; set; }
        public string TaxNo { get; set; }

        public int? DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }

        public int? CostCenterId { get; set; }
        [ForeignKey("CostCenterId")]
        public virtual CostCenter CostCenter { get; set; }

        public virtual ICollection<LeaveBalance> LeaveBalances { get; set; }



    }

   
}
