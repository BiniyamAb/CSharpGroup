using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CSharpGroup.Pages
{
    public class DeleteCategoryModel : PageModel
    {
        private readonly CSharpGroupContext _mycontext;
        public DeleteCategoryModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }

        public Category Category { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _mycontext.Categories.FirstOrDefaultAsync(m => m.Id == id);
            if (Category == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id,Category category)
        {
            if(id == null)
            {
                return NotFound();
            }

            category = await _mycontext.Categories.FindAsync(id);
            if (category != null)
            {
                _mycontext.Categories.Remove(category);
                await _mycontext.SaveChangesAsync();
            }

            return RedirectToPage("./AdminCat");
        }


    }

}
