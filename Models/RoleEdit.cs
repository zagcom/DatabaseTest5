using DatabaseTest5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseTest5.Models
{
    public class RoleEdit
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<DatabaseTest5User> Members { get; set; }
        public IEnumerable<DatabaseTest5User> NonMembers { get; set; }
    }
}
