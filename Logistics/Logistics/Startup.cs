using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Logistics.Entities;
using Logistics.Infrastructure;
using Logistics.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Logistics
{
    public class Startup
    {
        public static IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(env.ContentRootPath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                    .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            var connectionString = Configuration["ConnectionStrings:SecurityConnection"];
            services.AddDbContext<DatabaseContext>(o => o.UseSqlServer(connectionString));

            // register the repository
            services.AddTransient<IAirexpsRepository, AirexpsRepository>();
            services.AddTransient<ICommoditiesRepository, CommoditiesRepositor>();
            services.AddTransient<IContactsRepository, ContactsRepository>();
            services.AddTransient<IPositionsRepository, PositionsRepository>();
            services.AddTransient<IDepartmentsRepository, DepartmentsRepository>();
            services.AddTransient<IShipmentsRepository, ShipmentsRepository>();
            services.AddTransient<ITypeOfBillsRepository, TypeOfBillsRepository>();
            services.AddTransient<IUnitsRepository, UnitsRepository>();
            services.AddTransient<IPaymentsRepository, PaymentsRepository>();


            // Add AutoMappers
            Mapper.Initialize(cfg => cfg.AddProfile<MappingProfile>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseMvc();
            app.SeedData();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
