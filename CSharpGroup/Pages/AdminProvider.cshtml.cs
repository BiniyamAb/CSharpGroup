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

    public class AdminProviderModel : PageModel
    {
        public IList<Provider> providerList;
        public IList<User> userProviders;
        private readonly CSharpGroupContext _mycontext;

        public AdminProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            providerList = await _mycontext.Providers.ToListAsync();
            userProviders = await _mycontext.Users.ToListAsync();
            //provider.UserId = user.Entity.Id;
            foreach (var item in providerList)

            {

                foreach (var uid in userProviders)

                {
                    var userId = uid.Id;
                    if (item.UserId == userId)
                        Console.WriteLine($"name: {uid.FirstName}  + name: {uid.LastName}\n" +
                            $"image: {uid.Image} numberof providers: {item.Description}  description: {item.Category} " +
                            $"category: {item.JobsDone}");

                }
            }



        }
    }
}
