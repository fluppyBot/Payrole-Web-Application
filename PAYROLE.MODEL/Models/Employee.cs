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

        //Employme
        public int? PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
        public int? EmploymentTypeId { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }


        //Philippine Government Mandatories
        public string SssNo { get; set; }
        public string PagibigNo { get; set; }
        public string PhilhealthNo { get; set; }
        public string TaxNo { get; set; }

        


    }

   
}
