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
        public User loggedUser;
        //public Category item;
        //private readonly CategoryService _myService;

        public Single_ProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }

        public async Task OnGetAsync(int id)
        {
            
            HttpContext.Session.SetString("email", "bini@gmail.com");
            loggedUserEmail = HttpContext.Session.GetString("email");
            loggedUser = await _mycontext.Users.SingleOrDefaultAsync(c => c.Email == loggedUserEmail);
            //string categoryName = _mycontext.Categories.SingleOrDefault(c => c.Id == id).Name;
            //providersList = await _mycontext.Users.Where(u => u.Role == "provider").ToListAsync();
            providerUser = await _mycontext.Providers
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
                    .SingleOrDefaultAsync();
            
            _order = await _mycontext.Orders
                    .Where(o => o.SeekerId == loggedUser.Id && o.ProviderId == providerUser.ProviderId && !o.IsCompleted && o.Status != "declined")
                    .SingleOrDefaultAsync();
        }

        public IActionResult OnPostHire(int providerId, int loggedUserId)
        {
            var newOrder = new Order
            {
                Status = "pending",
                IsCompleted = false,
                ProviderId = providerId,
                SeekerId = loggedUserId
            };

            _mycontext.Add(newOrder);
            _mycontext.SaveChanges();
            Console.WriteLine($"status: {newOrder.Status}\nProviderId: {newOrder.ProviderId}\n SeekerId: {newOrder.SeekerId}");


            return RedirectToPage("/Single_Provider", new { id = providerId});

        }
    }
}
