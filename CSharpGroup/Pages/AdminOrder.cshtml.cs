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
    public class AdminOrderModel : PageModel
    {
        public IList<Provider> providerList;
        public IList<User> userProviders;
        public IList<Order> ordersList;
        public IList<Category> categoryList;
        private readonly CSharpGroupContext _mycontext;
        public AdminOrderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            providerList = await _mycontext.Providers.ToListAsync();
            userProviders = await _mycontext.Users.ToListAsync();
            categoryList = await _mycontext.Categories.ToListAsync();
            ordersList = await _mycontext.Orders.ToListAsync();
        }
    }
}
