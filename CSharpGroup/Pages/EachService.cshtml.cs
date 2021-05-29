using System;
using System.Collections.Generic;
using System.Linq;
using CSharpGroup.Data;
using CSharpGroup.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpGroup.Pages
{
    public class EachServiceModel : PageModel
    {
        private CSharpGroupContext _mycontext;
        public Category Service { get; set; }
        public EachServiceModel(CSharpGroupContext context)
        {
            _mycontext = context;
        }
        public void OnGet(int id)
        {
            Service =  _mycontext.Categories.SingleOrDefault(e => e.Id == id);
            Console.WriteLine($"{Service.Name}");
        }
    }
}
