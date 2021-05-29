using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using Microsoft.AspNetCore.Http;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpGroup.Pages
{
    public class Single_ProviderModel : PageModel
    {
        public ProviderUser providerUser;
        private readonly CSharpGroupContext _mycontext;
        public string loggedUserEmail;
        //public Category item;
        //private readonly CategoryService _myService;

        public Single_ProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public void OnGetAsync(int id)
        {
            loggedUserEmail = HttpContext.Session.GetString("email");
            //string categoryName = _mycontext.Categories.SingleOrDefault(c => c.Id == id).Name;
            //providersList = await _mycontext.Users.Where(u => u.Role == "provider").ToListAsync();
            providerUser = _mycontext.Providers
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
                    .Where(p => p.Id == id)
                    .SingleOrDefault();
        }

        //public IActionResult OnPostHire()
        //{
            
    
        //    if ()
        //    {
        //        return RedirectToPage("/Index", new { providerId = providerUser.Id});
        //    }
        //    User loggedUser = _mycontext.Users.SingleOrDefault(c => c.Email == userEmail);
        //    return Page();

        //}
    }
}
