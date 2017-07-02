using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PAYROLE.MODEL.Models;
using System;

namespace PAYROLE.DATA
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public UserLogAudit UserLogAudit { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserLogAudit> UserLogAudits { get; set; }
        public DbSet<CostCenter> CostCenters { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmploymentStatus> EmploymentStatuses { get; set; }
        public DbSet<EmploymentType> EmploymentType { get; set; }
        public DbSet<LeaveType> LeaveType { get; set; }
        public DbSet<LeaveBalance> LeaveBalances { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        
    }
}
