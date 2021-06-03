using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class AdminDashboardModel : PageModel
    {
        public IList<Provider> providerList;
        public IDictionary<string, decimal[]> values;
        public IList<User> userProviders;
        public decimal maxValue;
        public decimal minValue;

        public IList<Category> categoryList;

        public readonly CSharpGroupContext _mycontext;
        public AdminDashboardModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            categoryList = await _mycontext.Categories.ToListAsync();
            providerList = await _mycontext.Providers.ToListAsync();
            userProviders = await _mycontext.Users.ToListAsync();
            values = new Dictionary<string, decimal[]>();
            maxValue =0;
            minValue =501;
            //foreach (var item in categoryList)
            //{
            //    Console.WriteLine($"name: {item.Name} \nimage: {item.Image} numberof providers: {item.NumProviders}  description: {item.Description}");

            //}
            var PerHourWage = _mycontext.Providers.Max(p => p.PerHourWage);
            foreach (var category in categoryList)
            {
                foreach (var pro in providerList)
                {
                    if (pro.Category == category.Name)
                    {
                        if (pro.PerHourWage >= maxValue)
                        {
                            maxValue = pro.PerHourWage;
                        }
                        if (pro.PerHourWage <= minValue)
                        {
                            minValue = pro.PerHourWage;
                        }
                    }
                }
                values[category.Name] = new decimal[] { maxValue, minValue };
                maxValue = 0;
                minValue = 501;
                
            }
        }
    }
}
