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

namespace CSharpGroup.Pages
{
    public class ProfileModel : PageModel
    {
        public User userdetails { get; set; }
        public IList<User> userList;
        private readonly CSharpGroupContext _mycontext;
  
        public ProfileModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(User userdetails)
        {
            _mycontext.Update(userdetails);
            return Page();
            
        }
        public void Update(User user)
        {
            //definition for Update
            _mycontext.Users.Update(user);
        }

        //public async Task<IAsyncResult> UpdateAsync(string email, User userdetails)
        //{
        //    var existinguser = await _mycontext.FindAsync<string>(email);

        //    if (existinguser == null)
        //        return (IAsyncResult)Page();

        //    existinguser.FirstName = userdetails.FirstName;

        //    return (IAsyncResult)RedirectToPage("/Profile");
            
        //}

    }
    
}
