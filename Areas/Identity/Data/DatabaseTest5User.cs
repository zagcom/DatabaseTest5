using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DatabaseTest5.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the DatabaseTest5User class
    public class DatabaseTest5User : IdentityUser
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Function { get; set; }
    }
}
