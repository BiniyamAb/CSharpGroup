using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using Microsoft.AspNetCore.Http;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class JobsModel : PageModel
    {
        public readonly CSharpGroupContext _mycontext;
        public IList<Order> _orderList = null;
        public Order acceptedOrder;
        public int loggedProviderId;
        public JobsModel(CSharpGroupContext context)
        {
            _mycontext = context;            
        }
        public async Task OnGetAsync()
        {
            var providerUser = await _mycontext.Providers
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
                    )
                    .Where(p => p.Email == HttpContext.Session.GetString("email"))
                    .SingleOrDefaultAsync();

            loggedProviderId = providerUser.ProviderId;
            _orderList = await _mycontext.Orders
                .Where(o => o.Status == "pending" &&
                       o.ProviderId == loggedProviderId).ToListAsync();

            acceptedOrder = await _mycontext.Orders
                                        .Where(o => (o.Status == "accepted" || o.Status == "acceptedstarted" || o.Status == "acceptedfailed" || o.Status == "acceptedReviewing") && !o.IsCompleted &&
                                                o.ProviderId == loggedProviderId)
                                        .FirstOrDefaultAsync();
        }

        public async Task<IActionResult> OnPostAcceptAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            order.Status = "accepted";
            order.OrderCreatedDate = DateTime.Now.ToString();
            Random rnd = new Random();
            int randomNum = rnd.Next(9999);
            order.UniqueCode = randomNum;
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Jobs");
        }

        public async Task<IActionResult> OnPostDeclineAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).SingleOrDefaultAsync();
            order.Status = "declined";
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Jobs");
        }


    }
}
