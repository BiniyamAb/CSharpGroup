using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Category> categoryList;
        private readonly CSharpGroupContext _mycontext;
        public IList<ProviderUser> TopProviders;
        //public Category item;
        //private readonly CategoryService _myService;

        public IndexModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync(string searchstring)
        {

            var categories = from m in _mycontext.Categories select m;

            if (!String.IsNullOrEmpty(searchstring))
            {
                categories = categories.Where(s => s.Name.Contains(searchstring));

            }
            categoryList = await categories.ToListAsync();

            TopProviders = await _mycontext.Providers
                    .Join(
                        _mycontext.Users,
                        provider => provider.UserId,
                        user => user.Id,
                        (provider, user) => new ProviderUser
                        {
                            Id = user.Id,
                            Category = provider.Category,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Address = user.Address,
                            Role = user.Role,
                            JobsDone = provider.JobsDone,
                            AverageRating = provider.AverageRating,
                            PerHourWage = provider.PerHourWage,
                            Email = user.Email,
                            PhoneNo = user.PhoneNo,
                            ProviderId = provider.Id,
                            Image = user.Image,
                            Description = provider.Description,
                            Recommendation = provider.Recommendation
                        }
                    )
                    .Where(p => p.Role == "provider")
                    .OrderByDescending(p => p.AverageRating)
                    .Take(6)
                    .ToListAsync();
        }
    }
}
