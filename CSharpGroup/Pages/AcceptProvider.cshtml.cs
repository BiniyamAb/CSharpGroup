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
    public class AcceptProviderModel : PageModel
    {
        public User user { get; set; }
        public Provider provider { get; set; }
        public IList<User> userProviders;
        private readonly CSharpGroupContext _mycontext;

        public AcceptProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public IActionResult OnGet(int? id)

        {
            //HttpContext.Session.Clear();
            userProviders = _mycontext.Users.ToList();
            foreach (var item in userProviders)
            {
                if (item.Id == id)
                {
                   
                    item.Role = "provider";
                    _mycontext.Attach(item).State = EntityState.Modified;
                    _mycontext.SaveChanges();
                    return RedirectToPage("./AdminRequests");
                }
            }
            return NotFound();
        }
    }
}
