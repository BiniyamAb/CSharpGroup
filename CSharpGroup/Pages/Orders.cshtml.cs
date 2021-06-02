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
        public ReviewOrder reviewOrder { get; set; }
        //public int UniqueCode { get; set; }
        //public string Review { get; set; }
        //public int Rating { get; set; }
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
                            OrderCompletedDate=order.OrderCreatedDate,
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
                   .Where(o => (o.Status == "accepted" || o.Status == "acceptedstarted" || o.Status == "acceptedfailed" || o.Status == "acceptedReviewing") && !o.IsCompleted &&
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
        public async Task<IActionResult> OnPostStartTimeAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            order.StartTime = DateTime.UtcNow;
            order.Status = "acceptedstarted";
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Orders");
        }
        public async Task<IActionResult> OnPostCompleteAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            order.Status = "acceptedreviewing";
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Orders");
        }
        public async Task<IActionResult> OnPostPauseTimeAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            var newDif = DateTime.UtcNow.Subtract(order.StartTime).TotalHours;
            order.SavedTime += newDif;
            order.Status = "accepted";
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Orders");
        }
        public async Task<IActionResult> OnPostTryAgainAsync(int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            order.Status = "acceptedreviewing";
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Orders");
        }
        public async Task<IActionResult> OnPostFinishAsync(ReviewOrder reviewOrder, int orderId)
        {
            var order = await _mycontext.Orders.Where(o => o.Id == orderId).FirstOrDefaultAsync();
            if (order.UniqueCode == reviewOrder.UniqueCode)
            {
                var provider = await _mycontext.Providers.Where(p => p.Id == order.ProviderId).FirstOrDefaultAsync();
                var jobsDone = provider.JobsDone;
                var newJobsDone = jobsDone + 1;
                var newAverage = (((double)jobsDone * provider.AverageRating) + (double)reviewOrder.Rating) / (double)newJobsDone;
                order.Status = "accepted";
                order.IsCompleted = true;
                order.OrderCompletedDate = DateTime.Now.ToString();
                provider.JobsDone = newJobsDone;
                provider.AverageRating = newAverage;
                var review = new Review
                {
                    Rating = reviewOrder.Rating,
                    Comment = reviewOrder.Comment,
                    OrderId = orderId
                };

                _mycontext.Update(provider);
                await _mycontext.AddAsync(review);

            }
            else
            {
                order.Status = "acceptedfailed";
            }
            _mycontext.Update(order);
            await _mycontext.SaveChangesAsync();
            return RedirectToPage("/Orders");
           
        }
    }
}
