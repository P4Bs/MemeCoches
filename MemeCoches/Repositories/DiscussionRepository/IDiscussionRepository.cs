using MemeCoches.Models;

namespace MemeCoches.Repositories.DiscussionRepository
{
	public interface IDiscussionRepository
	{
		public Task<Discussion> GetDiscussionAsync(Guid DiscussionId);

		public Task InsertDiscussionAsync(Discussion discussion);
	}
}
