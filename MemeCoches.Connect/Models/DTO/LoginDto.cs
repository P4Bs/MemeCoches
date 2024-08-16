namespace MemeCoches.Connect.Models.DTO
{
	public record LoginDto
	{
		public string? Username { get; init; }
		public string? PasswordHash { get; init; }
	}
}
