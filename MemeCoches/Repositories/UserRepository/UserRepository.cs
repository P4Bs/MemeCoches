using MemeCoches.Models;
using MongoDB.Driver;
using System.Data;

namespace MemeCoches.Repositories.UserRepository
{
	public class UserRepository : BaseRepository, IUserRepository
	{
		private ILogger<UserRepository> _logger { get; set; }

        public UserRepository(IConfiguration config, ILoggerFactory loggerFactory) : base(config)
        {
			_logger = loggerFactory.CreateLogger<UserRepository>();
		}

		public async Task<User> GetUserAsync(Guid UserId)
		{
			// TODO: CREATE CONSTANTS
			IMongoCollection<User> userDataCollection = GetUserDataCollection();

			throw new NotImplementedException();
			// userDataCollection.FindAsync<User>
		}

		public async Task InsertUserAsync(User User)
		{
			IMongoCollection<User> userDataCollection = GetUserDataCollection();
			await userDataCollection.InsertOneAsync(User);
		}

		public async Task UpdateUserAsync(User User)
		{
			IMongoCollection<User> userDataCollection = GetUserDataCollection();

		}

		private IMongoCollection<User> GetUserDataCollection()
		{
			return Database.GetCollection<User>(typeof(User).Name);
		}
	}
}
