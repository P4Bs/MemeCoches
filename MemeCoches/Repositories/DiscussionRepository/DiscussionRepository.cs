using MemeCoches.Models;
using MongoDB.Driver;

namespace MemeCoches.Repositories.DiscussionRepository
{
	public class DiscussionRepository: BaseRepository, IDiscussionRepository
	{
		private ILogger<DiscussionRepository> _logger { get; set; }

        public DiscussionRepository(IConfiguration config, ILoggerFactory loggerFactory): base(config)
        {
            _logger = loggerFactory.CreateLogger<DiscussionRepository>();
        }

        public async Task<Discussion> GetDiscussionAsync(Guid DiscussionId)
        {
			throw new NotImplementedException();
        }

		public async Task InsertDiscussionAsync(Discussion discussion)
		{
			var discussionDataCollection = GetDiscussionDataCollection();
			await discussionDataCollection.InsertOneAsync(discussion);
		}

		private IMongoCollection<Discussion> GetDiscussionDataCollection()
		{
			return Database.GetCollection<Discussion>(typeof(Discussion).Name);
		}
	}

}
