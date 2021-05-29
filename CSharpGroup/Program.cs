using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var category = new Category { Name = "delivery", Image = "./img/delivery.jpg", NumProviders = 5, Description = "elivey category" };
            //await context.AddAsync(category);//await context.SaveChangesAsync();
            //var categoryList = await context.Categories.ToListAsync();
            //foreach (var item in categoryList)
            //{//
            //Console.WriteLine($"Name: {item.Name} Image: {item.Image} Numberof providers: {item.NumProviders}  Description: {item.Description}");
            //}
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
