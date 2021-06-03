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
    public class EditCategoryModel : PageModel
    {
        private readonly CSharpGroupContext _mycontext;
        public EditCategoryModel(CSharpGroupContext context)
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

        public async Task<IActionResult> OnPostAsync(Category category)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            category.Image = "./img/" + category.Image;

            _mycontext.Attach(category).State = EntityState.Modified;

            try
            {
                await _mycontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!categoryExists(category.Id))
                {
                    return NotFound();
                }

                else
                {
                    throw;
                }


            }
            return RedirectToPage("./AdminCat");
        }

        private bool categoryExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
