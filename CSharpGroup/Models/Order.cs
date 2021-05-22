using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGroup.Models
{
    public class Order : ModelInterface
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProviderId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string SeekerId { get; set; }
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
