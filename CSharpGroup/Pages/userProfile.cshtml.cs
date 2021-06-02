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
    public class userProfileModel : PageModel
    {
        public IList<Provider> providerList;
        public IList<User> userProviders;
        public readonly CSharpGroupContext _mycontext;
        public ProviderUser providerUser;
        public User user;
        public Order _order;
        public string loggedUserEmail;
        public User loggedUser = null;
        public int idForProvider;
        public userProfileModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync(int id)
        {
            providerList = await _mycontext.Providers.ToListAsync();
            userProviders = await _mycontext.Users.ToListAsync();
            loggedUserEmail = HttpContext.Session.GetString("email");
           
           





        }
    }
}

