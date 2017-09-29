using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project56.Models;
using Microsoft.EntityFrameworkCore;

namespace Project56
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
            services.AddDbContext<DBModel> (
                // opt => opt.UseNpgsql(@"Host=127.0.0.1;Port=5432;Database=MovieDB;Username=postgres;Password=stefan"));
                  opt => opt.UseNpgsql(@"Host=127.0.0.1;Port=5432;Database=admin_webshop;Username=postgres;Password=stefan"));

                  //   opt => opt.UseNpgsql(@"Host=54.36.99.83;Port=5432;Database=admin_webshop;Username=admin_webshop;Password=webshop123"));
            services.AddMvc();
         
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
