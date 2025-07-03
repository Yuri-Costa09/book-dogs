using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IProfileRepository
    {
        Task<Profile> GetProfileById(Guid id);
        Task<Profile> GetProfileByUserId(Guid userId);
        Task<Profile> GetProfileByUsername(string username);
        Task<List<Profile>> GetAllProfiles();
        Task CreateProfile(Profile profile);
        Task UpdateProfile(Profile profile);
        Task DeleteProfile(Guid id);
    }
}