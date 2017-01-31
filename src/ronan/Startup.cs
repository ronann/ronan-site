using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity;
using Microsoft.Data.Entity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;



namespace ronan
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

            app.UseStaticFiles();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //{
        //    loggerFactory.AddConsole(Configuration.GetSection("Logging"));
        //    loggerFactory.AddDebug();

        //    if (env.IsDevelopment())
        //    {
        //        app.UseBrowserLink();
        //        app.UseDeveloperExceptionPage();
        //        app.UseDatabaseErrorPage();
        //    }
        //    else
        //    {
        //        app.UseExceptionHandler("/Home/Error");

        //        // For more details on creating database during deployment see http://go.microsoft.com/fwlink/?LinkID=615859
        //        try
        //        {
        //            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
        //                .CreateScope())
        //            {
        //                serviceScope.ServiceProvider.GetService<ApplicationDbContext>()
        //                     .Database.Migrate();
        //            }
        //        }
        //        catch { }
        //    }

        //    app.UseIISPlatformHandler(options => options.AuthenticationDescriptions.Clear());

        //    app.UseStaticFiles();

        //    app.UseIdentity();

        //    // To configure external authentication please see http://go.microsoft.com/fwlink/?LinkID=532715

        //    app.UseMvc(routes =>
        //    {
        //        routes.MapRoute(
        //            name: "default",
        //            template: "{controller=Home}/{action=Index}/{id?}");
        //    });
        //}

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
