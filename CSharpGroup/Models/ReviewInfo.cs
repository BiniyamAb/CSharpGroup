using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class ReviewInfo
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int SeekerId { get; set; }
        public string OrderCreatedDate { get; set; }
        public string OrderCompletedDate { get; set; }
        public int ProviderId { get; set; }
    }
}
