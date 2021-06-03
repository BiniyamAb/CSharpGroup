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
    public class AcceptProviderModel : PageModel
    {
        public User user { get; set; }
        public Provider provider { get; set; }
        public IList<User> userProviders;
        private readonly CSharpGroupContext _mycontext;
        public IList<ProviderUser> providerUserList;

        public AcceptProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task<IActionResult> OnGet(int? id)

        {
            providerUserList = await _mycontext.Providers
                    .Join(
                        _mycontext.Users,
                        provider => provider.UserId,
                        user => user.Id,
                        (provider, user) => new ProviderUser
                        {
                            Id = provider.UserId,
                            Category = provider.Category,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Address = user.Address,
                            Role = user.Role,
                            JobsDone = provider.JobsDone,
                            AverageRating = provider.AverageRating,
                            PerHourWage = provider.PerHourWage,
                            Email = user.Email,
                            ProviderId = provider.Id,
                            PhoneNo = user.PhoneNo,
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
                    .ToListAsync();
            //HttpContext.Session.Clear();
            userProviders = await _mycontext.Users.ToListAsync();
            foreach (var item in userProviders)
            {
                if (item.Id == id)
                {
                    var categoryName = providerUserList.Where(p => p.Id == id).FirstOrDefault().Category;
                    item.Role = "provider";
                    var category = await _mycontext.Categories.Where(c => c.Name == categoryName).FirstOrDefaultAsync();
                    ++category.NumProviders;
                    _mycontext.Update(category);
                    _mycontext.Attach(item).State = EntityState.Modified;
                    await _mycontext.SaveChangesAsync();
                    return RedirectToPage("./AdminRequests");
                }
            }
            return NotFound();
        }
    }
}
