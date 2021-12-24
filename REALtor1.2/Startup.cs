using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using REALtor1._2.Data;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Repository;

namespace REALtor1._2
{
    public class Startup
    {
        private IConfigurationRoot _confString;
        public Startup(IHostingEnvironment host)
        {
            _confString = new ConfigurationBuilder().SetBasePath(host.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DbContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddTransient<IAllHouses,HouseRepository>();
            services.AddTransient<IAllPerson,PersonRepository>();
            services.AddMvc();
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Houses}/{action=MainView}"
                );
            });
            using (var scope = app.ApplicationServices.CreateScope())
            {
               DbContent content = scope.ServiceProvider.GetRequiredService<DbContent>();
               DbObjects.Initial(content);
            }
           

        }
    }
}
