using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class EachServiceModel : PageModel
    {
        private CSharpGroupContext _mycontext;
        public Category Service { get; set; }
        public IList<ProviderUser> TopProviders;
        public EachServiceModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync(int id)
        {
            Service =  await _mycontext.Categories.SingleOrDefaultAsync(e => e.Id == id);
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
                    .Where(p => p.Category == Service.Name && p.Role == "provider")
                    .OrderByDescending(p => p.AverageRating)
                    .Take(3)
                    .ToListAsync();
        }
    }
}
