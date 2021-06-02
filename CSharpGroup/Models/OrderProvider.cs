using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class OrderProvider
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
        public string OrderCreatedDate { get; set; }
        public string OrderCompletedDate { get; set; }
        public DateTime StartTime { get; set; }
        public double SavedTime { get; set; }
        public int UniqueCode { get; set; }

        public int ProviderId { get; set; }
        public Provider Provider { get; set; }

        public int SeekerId { get; set; }
        public User Seeker { get; set; }
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
