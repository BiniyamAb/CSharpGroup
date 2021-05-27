using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpGroup.Services;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpGroup.Pages
{
    public class ServicesModel : PageModel
    {
        public List<Category> categoryList;
        public Category item;
        private readonly CategoryService _myService;

        public ServicesModel(CategoryService myService)
        {
            _myService = myService;
        }
        public void OnGet()
        {
            //List<Category> categoryList = _myService.Get();
            Category item = _myService.Get("60a8d386d2696aebf303dfd5");
        }
    }
}
