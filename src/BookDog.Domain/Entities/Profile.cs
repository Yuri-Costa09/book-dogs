namespace BookDog.Domain.Entities
{
    public class Profile
    {
        public string UserName { get; set; }
        public string? Bio { get; set; }
        public string? ProfilePicture { get; set; }
        public string? Website { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? LinkedIn { get; set; }
        public string? Youtube { get; set; }

        public User User { get; set; }

        public Profile(string userName, string? bio, string? profilePicture, string? website, string? twitter, string? instagram, string? linkedin, string? youtube)
        {
            UserName = userName;
            Bio = bio;
            ProfilePicture = profilePicture;
            Website = website;
            Twitter = twitter;
            Instagram = instagram;
            LinkedIn = linkedin;
            Youtube = youtube;
        }
    }
}