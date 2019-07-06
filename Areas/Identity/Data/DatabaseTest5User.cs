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
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public string Unit { get; set; }
        [PersonalData]
        public string Function { get; set; }
    }
}
