using BookDog.Domain.Entities;

namespace BookDog.Application.Services.Interfaces
{
    public interface IProfileService
    {
        Profile GetProfile(Guid userId);
        void CreateProfile(Guid userId, string userName);
        void UpdateProfile(Guid userId, string userName, string bio, string profilePictureUrl,
            string InstagramUrl, string TwitterUrl, string LinkedinUrl, string YoutubeUrl);
        void DeleteProfile(Guid userId);
        List<Like> GetLikesByProfileId(Guid profileId);
    }
}