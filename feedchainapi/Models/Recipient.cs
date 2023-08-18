using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace feedchainapi.Models
{
    public class Recipient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; }
        public string? FatherName { get; set; }
        public string CNIC { get; set; }
        public string? Village { get; set; }
        public string? FullAddress { get; set; }
        public string? MobileNumber { get; set; }
        public string? FinancialSituation { get; set; }
        public string? EmploymentStatus { get; set; }
        public DateTime AidDate { get; set; } = DateTime.Now;
        public string? FeedBack { get; set; }
        public string? Gender { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
