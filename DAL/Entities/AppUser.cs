using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace DAL.Entities
{
    public class AppUser : IdentityUser
    {
        public int MyProperty { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;
    }
}