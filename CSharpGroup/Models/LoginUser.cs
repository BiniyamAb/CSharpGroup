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
        [MinLength(2, ErrorMessage = " Email cannot be smaller than 2 characters")]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(2, ErrorMessage = "Password must be greater than 2 characters.")]
        public string Password { get; set; }

    }
}
