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
    public class Provider_listModel : PageModel
    {
        public IList<ProviderUser> providersList;
        private readonly CSharpGroupContext _mycontext;
        //public Category item;
        //private readonly CategoryService _myService;

        public Provider_listModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync(int id)
        {
            var category = await _mycontext.Categories.SingleOrDefaultAsync(c => c.Id == id);
            //providersList = await _mycontext.Users.Where(u => u.Role == "provider").ToListAsync();
            providersList = _mycontext.Providers
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
                    //provider => provider.UserId,
                    //provider => provider.Category == categoryName,


                    //{
                    //    BookId = book.BookId,
                    //    AuthorName = author.Name,
                    //    BookTitle = book.Title
                    //}
                    )
                    .Where(p => p.Category.ToUpper() == category.Name.ToUpper())
                    .ToList();


            //var category = new Category { Name = "Delivery", Image = "./img/delivery.jpg", NumProviders = 5, Description = "Delivey Category" };
            //await _mycontext.AddAsync(category);
            //await _mycontext.SaveChangesAsync();
        }
    }
}
