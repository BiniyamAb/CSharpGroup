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
    public class DeleteProviderModel : PageModel
    {
        public Provider provider { get; set; }
        public User user { get; set; }
        private readonly CSharpGroupContext _mycontext;
        public DeleteProviderModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            provider = await _mycontext.Providers.FirstOrDefaultAsync(m => m.Id == id);
            user = await _mycontext.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (provider == null )
            {
                if(user == null)
                {
                    return NotFound();
                }
                return NotFound();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id, Provider provider, User user)
        {
            if (id == null)
            {
                return NotFound();
            }
            user = await _mycontext.Users.FindAsync(id);
            provider = await _mycontext.Providers.FindAsync(id);
            if (provider != null && user != null)
            {
                _mycontext.Providers.Remove(provider);
                _mycontext.Users.Remove(user);
                await _mycontext.SaveChangesAsync();
            }

            return RedirectToPage("./AdminProvider");
        }
    }
}
