using System;
using System.Collections.Generic;
using System.Linq;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        public void OnGet(int id)
        {
            Service =  _mycontext.Categories.SingleOrDefault(e => e.Id == id);
            TopProviders = _mycontext.Providers
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
                    .Where(p => p.Category == Service.Name)
                    .OrderByDescending(p => p.AverageRating)
                    .Take(6)
                    .ToList();
        }
    }
}
