//using System;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using SWSTechnologies1.Areas.Identity.Data;
//using SWSTechnologies1.Models;

//[assembly: HostingStartup(typeof(SWSTechnologies1.Areas.Identity.IdentityHostingStartup))]
//namespace SWSTechnologies1.Areas.Identity
//{
//    public class IdentityHostingStartup : IHostingStartup
//    {
//        public void Configure(IWebHostBuilder builder)
//        {
//            builder.ConfigureServices((context, services) => {
//                services.AddDbContext<SWSTechDBContext>(options =>
//                    options.UseSqlServer(
//                        context.Configuration.GetConnectionString("IdentityContextConnection")));

//                services.AddDefaultIdentity<ApplicationUser>()
//                    .AddEntityFrameworkStores<SWSTechDBContext>();
//            });
//        }
//    }
//}