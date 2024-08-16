using MongoDB.Bson.Serialization.Attributes;

namespace MemeCoches.Models
{
	public class ForumEntry
	{
		/// <summary>
		/// Forum entry ID
		/// </summary>
		[BsonId]
		public Guid Id { get; set; }

		/// <summary>
		/// User ID of forum entry
		/// </summary>
		public Guid AuthorId { get; set; }

		public DateTime PublicationDate { get; set; }

		/// <summary>
		/// Message content of forum entry
		/// </summary>
		public string? Message { get; set; }
	}
}
