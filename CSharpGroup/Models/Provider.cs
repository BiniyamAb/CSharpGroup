using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class Provider
    {
        [key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int JobsDone { get; set; }
        public decimal PerHourWage { get; set; }
        public string Recommendation { get; set; }
        public double AverageRating { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }

    }
}
