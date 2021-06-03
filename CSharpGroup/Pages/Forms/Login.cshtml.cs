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

namespace CSharpGroup.Pages.Forms
{
    public class LoginModel : PageModel
    {
        public int providerId;
        public IList<User> userList;
            private readonly CSharpGroupContext _mycontext;

            public User user { get; set; }
        public LoginModel(CSharpGroupContext context)
            {
                _mycontext = context;   
            }
        public void OnGet(int providerId)
            {
            this.providerId = providerId;
            }

        public IActionResult OnPost(LoginUser userSubmission, int providerId)
        {
           

            if (ModelState.IsValid)
            {
                var userInDb = _mycontext.Users.FirstOrDefault(u => u.Email == userSubmission.Email);
                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return Page();
                }
                else
                { 
                    var hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                    if (result == 0)
                    { 
                        ModelState.AddModelError("Email", "Invalid Email/Password");
                        return Page();
                    }
                    else
                    { 
                        HttpContext.Session.SetString("email", userInDb.Email);
                        HttpContext.Session.SetString("role", userInDb.Role);
                        if (userInDb.Role == "admin")
                        {
                            return RedirectToPage("/AdminCat");
                        }
                        if (providerId == 0)
                        {
                            return RedirectToPage("/Index");
                        }
                        
                             
                        return RedirectToPage("/Single_Provider", new { id = providerId , pag = 1});
                        
                        
                    }
                }

            }
            return Page();
        }


    }
}
