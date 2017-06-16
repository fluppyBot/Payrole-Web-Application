using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PAYROLE.MODEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLE.DATA
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Employee Profile { get; set; }

        public void NewProfile(string id,string lastName,string firstName,string middleName,DateTime birthDate,string gender)
        {
            Profile = new Employee
            {
                BirthDate = new DateTime(1990, 4, 14),
                FirsName = "Jordan",
                Gender = "Male",
                Id = "001",
                LastName = "Capoquian",
                MiddleName = "Nanag"
            };
        }
    }
}
