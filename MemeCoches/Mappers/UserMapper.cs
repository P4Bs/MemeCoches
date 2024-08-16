using MemeCoches.Database.Models;
using MemeCoches.Models;

namespace MemeCoches.Mappers
{
	public static class UserMapper
	{
		public static User ToUser(this UserEntity model)
		{
			return new()
			{
				Id = model.Id,
				Username = model.Username,
				Description = model.Description,
				Location = model.Location,
				ProfilePicture = model.ProfilePicture,
			};
		}
	}
}
