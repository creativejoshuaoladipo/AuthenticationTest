using Microsoft.AspNetCore.Identity;
using System;

namespace AuthenticationTest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
