using System;
using DatabaseTest5.Areas.Identity.Data;
using DatabaseTest5.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(DatabaseTest5.Areas.Identity.IdentityHostingStartup))]
namespace DatabaseTest5.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<DatabaseTest5Context>(options =>
                //    options.UseSqlServer(
                //        context.Configuration.GetConnectionString("DatabaseTest5ContextConnection")));

                services.AddIdentity<DatabaseTest5User, IdentityRole>()
                    .AddEntityFrameworkStores<DatabaseTest5Context>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders();

            });
        }
    }
}