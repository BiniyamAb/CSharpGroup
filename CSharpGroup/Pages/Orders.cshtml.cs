using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class OrdersModel : PageModel
    {
        public readonly Data.CSharpGroupContext _mycontext;
        public IList<OrderProvider> ordersList;
        public IList<OrderProvider> ordersHistory;
        public IList<OrderProvider> ordersAccepted;
        public int loggedUserId; 
        public OrdersModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            var loggedUser = await  _mycontext.Users.Where(p => p.Email == HttpContext.Session.GetString("email"))
                    .SingleOrDefaultAsync();
            loggedUserId = loggedUser.Id;

            ordersList = await _mycontext.Orders
                    .Join(
                        _mycontext.Providers,
                        order => order.ProviderId,
                        provider => provider.Id,
                        (order, provider) => new OrderProvider
                        {
                            Id = order.Id,
                            Status=order.Status,
                            IsCompleted=order.IsCompleted,
                            OrderCreatedDate=order.OrderCreatedDate,
                            StartTime= order.StartTime,
                            SavedTime=order.SavedTime,
                            UniqueCode=order.UniqueCode,
                            ProviderId=provider.Id,
                            SeekerId=order.SeekerId,
                            Description=provider.Description,
                            Category=provider.Category,
                            JobsDone=provider.JobsDone,
                            PerHourWage=provider.PerHourWage,
                            Recommendation=provider.Recommendation,
                            AverageRating=provider.AverageRating,
                            UserId= provider.UserId
                        }
                    )
                   .Where(o => (o.Status == "pending" || o.Status == "declined") &&
                       (o.SeekerId == loggedUserId)).ToListAsync();

            ordersHistory = await _mycontext.Orders
                    .Join(
                        _mycontext.Providers,
                        order => order.ProviderId,
                        provider => provider.Id,
                        (order, provider) => new OrderProvider
                        {
                            Id = order.Id,
                            Status = order.Status,
                            IsCompleted = order.IsCompleted,
                            OrderCreatedDate = order.OrderCreatedDate,
                            StartTime = order.StartTime,
                            SavedTime = order.SavedTime,
                            UniqueCode = order.UniqueCode,
                            ProviderId = provider.Id,
                            SeekerId = order.SeekerId,
                            Description = provider.Description,
                            Category = provider.Category,
                            JobsDone = provider.JobsDone,
                            PerHourWage = provider.PerHourWage,
                            Recommendation = provider.Recommendation,
                            AverageRating = provider.AverageRating,
                            UserId = provider.UserId
                        }
                    )
                   .Where(o => o.IsCompleted &&
                       (o.SeekerId == loggedUserId)).ToListAsync();

            ordersAccepted = await _mycontext.Orders
                    .Join(
                        _mycontext.Providers,
                        order => order.ProviderId,
                        provider => provider.Id,
                        (order, provider) => new OrderProvider
                        {
                            Id = order.Id,
                            Status = order.Status,
                            IsCompleted = order.IsCompleted,
                            OrderCreatedDate = order.OrderCreatedDate,
                            StartTime = order.StartTime,
                            SavedTime = order.SavedTime,
                            UniqueCode = order.UniqueCode,
                            ProviderId = provider.Id,
                            SeekerId = order.SeekerId,
                            Description = provider.Description,
                            Category = provider.Category,
                            JobsDone = provider.JobsDone,
                            PerHourWage = provider.PerHourWage,
                            Recommendation = provider.Recommendation,
                            AverageRating = provider.AverageRating,
                            UserId = provider.UserId
                        }
                    )
                   .Where(o => o.Status == "accepted" && !o.IsCompleted &&
                       (o.SeekerId == loggedUserId)).ToListAsync();


        }

        public async Task<IActionResult> OnPostCancelAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            _mycontext.Remove(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Orders");
        }

        public async Task<IActionResult> OnPostSomeOneElseAsync(int orderId, string categoryName)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            var category = await _mycontext.Categories.Where(c => c.Name == categoryName).FirstOrDefaultAsync();
            _mycontext.Remove(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Provider_list",  new { id = category.Id});
        }
    }
}
