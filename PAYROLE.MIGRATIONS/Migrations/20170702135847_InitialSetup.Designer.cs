using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PAYROLE.DATA;
using PAYROLE.MODEL.Models;

namespace PAYROLE.MIGRATIONS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170702135847_InitialSetup")]
    partial class InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PAYROLE.DATA.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfileId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("ProfileId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.CostCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CostCenters");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Description");

                    b.Property<int>("DivisionId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("ContactNo");

                    b.Property<int?>("CostCenterId");

                    b.Property<DateTime>("DateHired");

                    b.Property<int?>("DepartmentId");

                    b.Property<int?>("EmploymentStatusId");

                    b.Property<int?>("EmploymentTypeId");

                    b.Property<string>("FirsName")
                        .IsRequired();

                    b.Property<string>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int?>("LocationId");

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("MiddleName");

                    b.Property<string>("PagibigNo");

                    b.Property<string>("PhilhealthNo");

                    b.Property<int?>("PositionId");

                    b.Property<string>("SssNo");

                    b.Property<string>("TaxNo");

                    b.HasKey("Id");

                    b.HasIndex("CostCenterId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmploymentStatusId");

                    b.HasIndex("EmploymentTypeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("PositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.EmploymentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("EmploymentStatuses");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.EmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<string>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("LastModifiedBy");

                    b.Property<string>("LastModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("EmploymentType");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.LeaveBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmployeeId");

                    b.Property<int>("LeaveTypeId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LeaveTypeId");

                    b.ToTable("LeaveBalances");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.LeaveType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Default");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LeaveType");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("LastUpdatedBy");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.UserLogAudit", b =>
                {
                    b.Property<int>("UserAuditId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuditEvent");

                    b.Property<string>("IpAddress");

                    b.Property<DateTimeOffset>("Timestamp");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("UserAuditId");

                    b.ToTable("UserLogAudits");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PAYROLE.DATA.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PAYROLE.DATA.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PAYROLE.DATA.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PAYROLE.DATA.ApplicationUser", b =>
                {
                    b.HasOne("PAYROLE.MODEL.Models.Employee", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Department", b =>
                {
                    b.HasOne("PAYROLE.MODEL.Models.Division", "Division")
                        .WithMany("Departments")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.Employee", b =>
                {
                    b.HasOne("PAYROLE.MODEL.Models.CostCenter", "CostCenter")
                        .WithMany("Employees")
                        .HasForeignKey("CostCenterId");

                    b.HasOne("PAYROLE.MODEL.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("PAYROLE.MODEL.Models.EmploymentStatus", "EmploymentStatus")
                        .WithMany("Employees")
                        .HasForeignKey("EmploymentStatusId");

                    b.HasOne("PAYROLE.MODEL.Models.EmploymentType", "EmploymentType")
                        .WithMany("Employees")
                        .HasForeignKey("EmploymentTypeId");

                    b.HasOne("PAYROLE.MODEL.Models.Location", "Location")
                        .WithMany("Employees")
                        .HasForeignKey("LocationId");

                    b.HasOne("PAYROLE.MODEL.Models.Position", "Position")
                        .WithMany("Profiles")
                        .HasForeignKey("PositionId");
                });

            modelBuilder.Entity("PAYROLE.MODEL.Models.LeaveBalance", b =>
                {
                    b.HasOne("PAYROLE.MODEL.Models.Employee", "Employee")
                        .WithMany("LeaveBalances")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("PAYROLE.MODEL.Models.LeaveType", "LeaveType")
                        .WithMany("LeaveBalances")
                        .HasForeignKey("LeaveTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
