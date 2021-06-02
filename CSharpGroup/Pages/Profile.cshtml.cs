using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class ProfileModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        public User userdetails { get; set; }
        public IList<User> userList;
        public IList<Provider> providerList;
       
        public readonly CSharpGroupContext _mycontext;

        public ProfileModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync(int id)
        {
            providerList = await _mycontext.Providers.ToListAsync();
            userList = await _mycontext.Users.ToListAsync();
           
            var em = HttpContext.Session.GetString("email");
            user = _mycontext.Users.SingleOrDefault(a => a.Email.Equals(em));

        }
       
        public IActionResult OnPost()
        {
            var em = HttpContext.Session.GetString("email");
            user.Id = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Email == em).Id;

            if (!string.IsNullOrEmpty(user.Password))
            {

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

            }
            else
            {
                user.Password = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Id == user.Id).Password;
            }
            if (string.IsNullOrEmpty(user.FirstName))
            {

                user.FirstName = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Id == user.Id).FirstName;
            }

            if (string.IsNullOrEmpty(user.Email))
            {
                user.Email = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Id == user.Id).Email;

            }
            if (string.IsNullOrEmpty(user.LastName))
            {
                user.LastName = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Id == user.Id).LastName;

            }
            if (string.IsNullOrEmpty(user.PhoneNo))
            {
                user.PhoneNo = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Id == user.Id).PhoneNo;

            }
            if (string.IsNullOrEmpty(user.Address))
            {
                user.Address = _mycontext.Users.AsNoTracking().SingleOrDefault(a => a.Id == user.Id).Address;

            }






            _mycontext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _mycontext.SaveChanges();
            return Page();



        }




    }

}
