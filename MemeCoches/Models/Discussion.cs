using MongoDB.Bson.Serialization.Attributes;

namespace MemeCoches.Models
{
	public class Discussion
	{
		[BsonId]
		public Guid Id { get; set; }
		public DateTime CreationDate { get; set; }
		public Guid Author { get; set; }
		public Guid Theme { get; set; }
		public string? Title { get; set; }
	}
}
