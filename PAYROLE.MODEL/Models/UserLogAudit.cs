using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PAYROLE.MODEL.Models
{
    public class UserLogAudit
    {
        [Key]
        public int UserAuditId { get; private set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTimeOffset Timestamp { get; private set; } = DateTime.UtcNow;

        [Required]
        public UserAuditEventType AuditEvent { get; set; }

        public string IpAddress { get; set; }
        
    }

    public enum UserAuditEventType
    {
        Login = 1,
        FailedLogin = 2,
        LogOut = 3
    }
}
