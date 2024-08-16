namespace MemeCoches.Database.Models
{
	public class DiscussionEntity
	{
		public Guid Id { get; set; }
		public DateTime Creation_Date { get; set; }
		public Guid User_Id { get; set; }
		public Guid Theme_Id { get; set; }
		public string? Title { get; set; }
	}
}
