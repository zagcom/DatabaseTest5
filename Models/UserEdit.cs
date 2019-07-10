using DatabaseTest5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTest5.Models
{
    public class UserEdit
    {
        public DatabaseTest5User User { get; set; }
        public IEnumerable<IdentityRole> UserRoles { get; set; }
        public IEnumerable<IdentityRole> UserNonRoles { get; set; }
    }
}
