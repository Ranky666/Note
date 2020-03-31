using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore; // пространство имен EntityFramework
using NoteBook.Models;
using NoteBook.BL.Services;
using NoteBook.BL.Interfaces;
using NoteBook.DAL.Interfaces;
using NoteBook.DAL.Repositories;
using NoteBook.DAL.EF;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace NoteBook
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<NoteContext>(options => options.UseSqlServer(connection));
            services.AddControllersWithViews();
            services.AddTransient<INoteService, NoteService>();
            services.AddTransient<INoteRepository, NoteRepository>();
            services.AddSingleton<Profile, NoteBook.Mapping.NoteProfile>();
            services.AddSingleton<Profile, NoteBook.DAL.Mapping.NoteProfile>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddSingleton(x =>
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfiles(x.GetServices<Profile>());
                });
                config.AssertConfigurationIsValid();
                return config.CreateMapper(x.GetService);
            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
                });
            services.AddControllersWithViews();


        }

        public void Configure(IApplicationBuilder app, NoteContext context)
        {
            context.Database.EnsureCreated();
           
            app.UseDeveloperExceptionPage();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
