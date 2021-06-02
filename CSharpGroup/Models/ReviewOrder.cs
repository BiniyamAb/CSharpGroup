using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class ReviewOrder
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
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
    }
}
