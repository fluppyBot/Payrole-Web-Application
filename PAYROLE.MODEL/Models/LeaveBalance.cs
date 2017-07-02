using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class LeaveBalance
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public virtual LeaveType LeaveType { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
