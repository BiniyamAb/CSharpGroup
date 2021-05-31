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
                    )
                    .Where(p => p.Email == HttpContext.Session.GetString("email"))
                    .SingleOrDefaultAsync();

            loggedProviderId = providerUser.Id;
            _orderList = await _mycontext.Orders
                .Where(o => o.Status == "pending" &&
                       o.ProviderId == loggedProviderId).ToListAsync();
        }

        public async Task<IActionResult> OnPostAcceptAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).SingleOrDefaultAsync();
            order.Status = "accepted";
            order.OrderCreatedDate = DateTime.Now.ToString();
            Random rnd = new Random();
            int randomNum = rnd.Next(9999);
            order.UniqueCode = randomNum;
            return Page();
        }

        public async Task<IActionResult> OnPostDeclineAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).SingleOrDefaultAsync();
            order.Status = "declined";
            return Page();
        }

    }
}
