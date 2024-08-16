using MemeCoches.Database.Models;
using MemeCoches.Models;

namespace MemeCoches.Mappers
{
	public static class DiscussionMapper
	{
		public static Discussion ToDiscussion(this DiscussionEntity model)
		{
			return new()
			{
				Id = model.Id,
				CreationDate = model.Creation_Date,
				Author = model.User_Id,
				Theme = model.Theme_Id,
				Title = model.Title
			};
		}
	}
}
