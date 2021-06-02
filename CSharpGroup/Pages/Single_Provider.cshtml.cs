using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using Microsoft.AspNetCore.Http;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace CSharpGroup.Pages
{
    public class Single_ProviderModel : PageModel
    {
        public ProviderUser providerUser;
        private readonly CSharpGroupContext _mycontext;
        public Order _order;
        public string loggedUserEmail;
        public User loggedUser= null;
        public int idForProvider;
        //public Category item;
        //private readonly CategoryService _myService;

        public Single_ProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }

        public async Task OnGetAsync(int id)
        {
            
           
            loggedUserEmail = HttpContext.Session.GetString("email");
            idForProvider = id;
            //string categoryName = _mycontext.Categories.SingleOrDefault(c => c.Id == id).Name;
            //providersList = await _mycontext.Users.Where(u => u.Role == "provider").ToListAsync();
            providerUser = await _mycontext.Providers
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
                    .Where(p => p.Id == id)
                    .SingleOrDefaultAsync();
            if (loggedUserEmail != null)
            {
                
                loggedUser = await _mycontext.Users.SingleOrDefaultAsync(c => c.Email == loggedUserEmail);
                _order = await _mycontext.Orders
                    .Where(o => o.SeekerId == loggedUser.Id)
                    .Where(o => o.ProviderId == providerUser.ProviderId)
                    .Where(o => !o.IsCompleted)
                    .Where(o => o.Status != "declined")
                    .FirstOrDefaultAsync();
            }
            

          
        }

        public async Task<IActionResult> OnPostHireAsync(int providerId, int loggedUserId, int providerUserId)
        {
            var newOrder = new Order
            {
                Status = "pending",
                IsCompleted = false,
                ProviderId = providerId,
                SeekerId = loggedUserId
            };
            await _mycontext.AddAsync(newOrder);
            await _mycontext.SaveChangesAsync();


            return RedirectToPage("/Single_Provider", new { id = providerUserId });

        }
    }
}
