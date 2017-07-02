using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class LeaveType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Default { get; set; }

        public virtual ICollection<LeaveBalance> LeaveBalances { get; set; }
    }
}
