using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
        public string OrderCreatedDate { get; set; }
        public string OrderCompletedDate { get; set; }
        public DateTime StartTime { get; set; }
        public double SavedTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ProviderId { get; set; }
        public int SeekerId { get; set; }

        public Provider Provider { get; set; }
        public User Seeker { get; set; }
    }
}
