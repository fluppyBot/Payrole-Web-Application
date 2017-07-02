using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class EmploymentStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
