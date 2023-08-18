using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace feedchainapi.Models
{
    public class Users
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
