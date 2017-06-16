using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class EmploymentType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedDate { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
