using MongoDB.Bson.Serialization.Attributes;

namespace MemeCoches.Models
{
	public class User
	{
		[BsonId]
		public Guid Id { get; set; }
		public string? Username { get; set; }
		public string? Description { get; set; }
		public string? Location { get; set; }
		public byte[]? ProfilePicture { get; set; }
	}
}
