using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpGroup.Pages
{
    public class AddCategoryModel : PageModel
    {
        private readonly CSharpGroupContext _mycontext;
        public AddCategoryModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public Category Category { get; set; }

        public async Task<IActionResult> OnPostAsync(Category category)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            category.Image = "./img/" + category.Image;
            _mycontext.Categories.Add(category);
            await _mycontext.SaveChangesAsync();

            return RedirectToPage("./AdminCat");
        }

    }
}
