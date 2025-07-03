using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IProfileRepository
    {
        Task<Profile> GetProfileById(Guid id);
        Task<Profile> GetProfileByUserId(Guid userId);
        Task<Profile> GetProfileByUsername(string username);
        Task<List<Profile>> GetAllProfiles();
        void CreateProfile(Profile profile);
        void UpdateProfile(Profile profile);
        void DeleteProfile(Guid id);
    }
}