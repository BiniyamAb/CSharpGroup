using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class ProviderUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int JobsDone { get; set; }
        public decimal PerHourWage { get; set; }
        public string Recommendation { get; set; }
        public double AverageRating { get; set; }
    }
}
