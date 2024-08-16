using MongoDB.Driver;

namespace MemeCoches.Repositories
{
	public class BaseRepository(IConfiguration config)
	{
		private readonly IConfiguration _config = config;

		protected IMongoDatabase Database => new MongoClient().GetDatabase(_config.GetConnectionString("MongoDatabaseConnectionString"));
	}
}
