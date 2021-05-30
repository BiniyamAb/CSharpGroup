using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class User 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName cannot be Empty.")]
        [MinLength(2, ErrorMessage = "First Name cannot be smaller than 2 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName cannot be Empty.")]
        [MinLength(2, ErrorMessage = "Last Name cannot be smaller than 2 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email cannot be Empty.")]
        [MinLength(2, ErrorMessage = " Email cannot be smaller than 2 characters")]
        [EmailAddress]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required]
        [MinLength(2, ErrorMessage = "Password must be greater than 2 characters.")]
        public string Password { get; set; }


        [NotMapped]
        [Compare("Password", ErrorMessage = "Password and password confirmation did not match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }


        public string PhoneNo { get; set; }

        public string Image { get; set; }
        [Required]
        
        public string  Address{ get; set; }
        public string Role { get; set; }


    }
}
