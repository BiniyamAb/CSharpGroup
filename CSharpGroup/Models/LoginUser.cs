using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class LoginUser 
    {
        [Key]
        public string Id { get; set; }

        [Required]
       
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
       
        public string Password { get; set; }

    }
}
