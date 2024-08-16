using MemeCoches.Models;

namespace MemeCoches.Repositories.UserRepository
{
	public interface IUserRepository
	{
		public Task<User> GetUserAsync(Guid UserId);

		public Task InsertUserAsync(User User);

		public Task UpdateUserAsync(User User);
	}
}
