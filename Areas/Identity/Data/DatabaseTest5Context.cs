using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseTest5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DatabaseTest5.Models;

namespace DatabaseTest5.Models
{
    public class DatabaseTest5Context : IdentityDbContext<DatabaseTest5User>
    {
        public DatabaseTest5Context(DbContextOptions<DatabaseTest5Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<DatabaseTest5.Models.Camp> Camp { get; set; }
    }
}
