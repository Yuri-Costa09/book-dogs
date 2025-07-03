using BookDog.Domain.Entities;

namespace BookDog.Application.Repositories
{
    public interface IProfileRepository
    {
        public Task<Profile> GetProfileById(Guid id);
        public Task<Profile> GetProfileByUserId(Guid userId);
        public Task<Profile> GetProfileByUsername(string username);
        public Task<List<Profile>> GetAllProfiles();
        public void CreateProfile(Profile profile);
        public void UpdateProfile(Profile profile);
        public void DeleteProfile(Guid id);
    }
}