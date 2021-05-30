using CSharpGroup.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Data
{
    public class CSharpGroupContext : DbContext
    {
        public CSharpGroupContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=myDb;User Id=Csharp;Password=Csharp;Trusted_Connection=True;MultipleActiveResultSets=true");

        internal Task<IdentityResult> UpdateAsync(User userdetails)
        {
            throw new NotImplementedException();
        }
    }
}
