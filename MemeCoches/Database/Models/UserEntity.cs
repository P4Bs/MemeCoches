namespace MemeCoches.Database.Models
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public byte[]? ProfilePicture { get; set; }
    }
}
