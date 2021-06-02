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
    public class AdmintryModel : PageModel
    {
        public IList<Category> categoryList;
        private readonly CSharpGroupContext _mycontext;
        public AdmintryModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            categoryList = await _mycontext.Categories.ToListAsync();
            //foreach (var item in categoryList)
            //{
            //    Console.WriteLine($"name: {item.Name} \nimage: {item.Image} numberof providers: {item.NumProviders}  description: {item.Description}");

            //}
        }
    }
}
