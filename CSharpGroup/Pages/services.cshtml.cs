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

            //var category1 = new Category
            //{
            //    Name = "Delivery",
            //    Image = "./img/delivery.jpg",
            //    NumProviders = 0,
            //    Description = "Delivey Category"
            //};
            //var category2 = new Category
            //{
            //    Name = "Electrician",
            //    Image = "./img/electrician.jpg",
            //    NumProviders = 0,
            //    Description = "Electrician Category"
            //};
            //var category3 = new Category
            //{
            //    Name = "Painting",
            //    Image = "./img/painting.jpg",
            //    NumProviders = 0,
            //    Description = "Painting Category"
            //};
            //var category4 = new Category
            //{
            //    Name = "Cleaning",
            //    Image = "./img/cleaning.jpg",
            //    NumProviders = 0,
            //    Description = "cleaning Category"
            //};
            //var category5 = new Category
            //{
            //    Name = "Mechanic",
            //    Image = "./img/mechanic.jpg",
            //    NumProviders = 5,
            //    Description = "mechanic Category"
            //};
            //var category6 = new Category
            //{
            //    Name = "Construction",
            //    Image = "./img/construction.jpg",
            //    NumProviders = 5,
            //    Description = "construction Category"
            //};
            //await _mycontext.AddAsync(category1);
            //await _mycontext.AddAsync(category2);
            //await _mycontext.AddAsync(category3);
            //await _mycontext.AddAsync(category4);
            //await _mycontext.AddAsync(category5);
            //await _mycontext.AddAsync(category6);
            //await _mycontext.SaveChangesAsync();
            //foreach (var item in categoryList)
            //{
            //    Console.WriteLine($"Name: {item.Name} Image: {item.Image} Numberof providers: {item.NumProviders}  Description: {item.Description}");
            //    _mycontext.Categories.Remove(item);
            //}
            //await _mycontext.SaveChangesAsync();
        }
    }
}
