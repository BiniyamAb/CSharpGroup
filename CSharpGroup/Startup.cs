using CSharpGroup.Models;
using CSharpGroup.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup
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
            services.Configure<CSharpGroupDatabaseSettings>(
                Configuration.GetSection(nameof(CSharpGroupDatabaseSettings)));

            services.AddSingleton<ICSharpGroupDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<CSharpGroupDatabaseSettings>>().Value);
            services.AddSingleton<MongoClientService>();
            services.AddSingleton<CRUDService<User>>();
            services.AddSingleton<CRUDService<Provider>>();
            services.AddSingleton<CRUDService<Category>>();
            services.AddSingleton<CRUDService<Order>>();
            services.AddSingleton<CRUDService<Review>>();

            services.AddRazorPages();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
