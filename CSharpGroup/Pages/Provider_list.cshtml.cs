using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class Provider_listModel : PageModel
    {
        public IList<ProviderUser> providersList;
        public IList<Category> categories;
        public SelectList addresses;
        public SelectList perhours;
        private readonly CSharpGroupContext _mycontext;
        public string address2;
        public decimal per;
        //public Category item;
        //private readonly CategoryService _myService;

        public Provider_listModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync(int id, string searchstring, decimal perhour, string address)
        {
            var category = await _mycontext.Categories.SingleOrDefaultAsync(c => c.Id == id);
            IQueryable<decimal> prov= from m in _mycontext.Providers orderby m.PerHourWage select m.PerHourWage;
            IQueryable<string> user = from m in _mycontext.Users orderby m.Address select m.Address;
            perhours = new SelectList(await prov.Distinct().ToListAsync());
            addresses = new SelectList(await user.Distinct().ToListAsync());
            //providersList = await _mycontext.Users.Where(u => u.Role == "provider").ToListAsync();
            providersList = await _mycontext.Providers
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
                    .Where(p => p.Category.ToUpper() == category.Name.ToUpper() && p.Role == "provider")
                    .ToListAsync();

            if (!String.IsNullOrEmpty(searchstring))
            {
                providersList = await _mycontext.Providers
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
                    .Where(p => p.Category.ToUpper() == category.Name.ToUpper() && p.Role == "provider" && (p.FirstName.Contains(searchstring) || p.LastName.Contains(searchstring)) )
                    .ToListAsync();
            }

            if (!String.IsNullOrEmpty(address))
            {
                providersList = await _mycontext.Providers
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
                    .Where(p => p.Category.ToUpper() == category.Name.ToUpper() && p.Role == "provider" && p.Address.Contains(address))
                    .ToListAsync();
            }

            if (perhour>0)
            {
                providersList = await _mycontext.Providers
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
                    .Where(p => p.Category.ToUpper() == category.Name.ToUpper() && p.Role == "provider" && p.PerHourWage==perhour)
                    .ToListAsync();
            }

           


            //provider => provider.UserId,
            //provider => provider.Category == categoryName,


            //{
            //    BookId = book.BookId,
            //    AuthorName = author.Name,
            //    BookTitle = book.Title
            //}



            //var category = new Category { Name = "Delivery", Image = "./img/delivery.jpg", NumProviders = 5, Description = "Delivey Category" };
            //await _mycontext.AddAsync(category);
            //await _mycontext.SaveChangesAsync();
        }
    }
}
