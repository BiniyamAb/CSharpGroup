using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

       
        public string Name { get; set; }
        public string Image { get; set; }
        public int NumProviders { get; set; }
        public string Description { get; set; }
    }
}
