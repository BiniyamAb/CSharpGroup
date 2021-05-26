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
        //public List<Category> categoryList;
        //private readonly CRUDService<Category> _myService;

        //public servicesModel(CRUDService<Category> myService)
        //{
        //    _myService = myService;
        //}
        public void OnGet()
        {
            //List<Category> categoryList = _myService.Get();
        }
    }
}
