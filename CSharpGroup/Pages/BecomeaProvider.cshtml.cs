using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CSharpGroup.Models;
using CSharpGroup.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
namespace CSharpGroup.Pages
{
    public class BecomeaProviderModel : PageModel
    {
        public IList<User> userlist;
        public IList<Category> categorylist;
        private readonly CSharpGroupContext _mycontext;
        public User user { get; set; }
        public Provider provider { get; set; }

        public BecomeaProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            categorylist = await _mycontext.Categories.ToListAsync();
        }
        public async Task<IActionResult> OnPostAsync(User user, Provider provider)
        {
            if (ModelState.IsValid)
            {
                if (_mycontext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use.");
                    return RedirectToPage("/Index");
                }

                
              
                
                
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                user.Role = "providerRequesting";
                var users = await _mycontext.Users.AddAsync(user);
                await _mycontext.SaveChangesAsync();

                provider.UserId = users.Entity.Id;
                await _mycontext.Providers.AddAsync(provider);
                await _mycontext.SaveChangesAsync();


                HttpContext.Session.SetString("email", user.Email);
                HttpContext.Session.SetString("role", user.Role);

                return RedirectToPage("/Index");
            }
            return Page();

        }
    }
}
