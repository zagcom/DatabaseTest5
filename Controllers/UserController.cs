using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTest5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DatabaseTest5.Models;

namespace DatabaseTest5.Controllers
{
    public class UserController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<DatabaseTest5User> userManager;
        public UserController(UserManager<DatabaseTest5User> userMrg, RoleManager<IdentityRole> roleMgr)
        {
            roleManager = roleMgr;
            userManager = userMrg;
        }

        public ViewResult Index() => View(userManager.Users);

    }
}



