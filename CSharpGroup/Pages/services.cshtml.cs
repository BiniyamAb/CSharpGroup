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
    public class ServicesModel : PageModel
    {
        public IList<Category> categoryList;
        private readonly CSharpGroupContext _mycontext;
        //public Category item;
        //private readonly CategoryService _myService;

        public ServicesModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public async Task OnGetAsync()
        {
            categoryList = await _mycontext.Categories.ToListAsync();
            //List<Category> categoryList = _myService.Get();
            //Category item = _myService.Get("60a8d386d2696aebf303dfd5");


            //var category = new Category { Name = "Delivery", Image = "./img/delivery.jpg", NumProviders = 5, Description = "Delivey Category" };
            //await _mycontext.AddAsync(category);
            //await _mycontext.SaveChangesAsync();
        }
    }
}
