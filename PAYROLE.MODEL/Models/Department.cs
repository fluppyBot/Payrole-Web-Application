using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DivisionId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Division Division { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
