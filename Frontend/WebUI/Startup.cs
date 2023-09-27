using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.DTOs.GuestDto;
using WebUI.ValidationRules.GuestValidationRules;

namespace WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>();
            services.AddHttpClient();
            services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
            services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
            services.AddControllersWithViews().AddFluentValidation();
            services.AddAutoMapper(typeof(Startup));
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder() 
                .RequireAuthenticatedUser() // otantik olmuþ kullanýcý 
                .Build();// inþa et
                config.Filters.Add(new AuthorizeFilter(policy)); // policy filtre et 

            });

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;// httpye izin ver 
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10); // sitelerde yeniden giriþ yapma bankaclýkta daha az oluyor
                options.LoginPath = "/Login/Index/";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStatusCodePagesWithReExecute("/EroorPage/Error404", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
